using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Coroutines.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime.Coroutines
{
    public class LoadBuildsResourcesCoroutine : Coroutine<IReadOnlyList<IModuleBuild>>
    {
        public IReadOnlyList<IModuleBuildInfo> Infos { get; }

        public LoadBuildsResourcesCoroutine(IReadOnlyList<IModuleBuildInfo> infos)
        {
            Infos = infos ?? throw new ArgumentNullException(nameof(infos));
        }

        protected override IEnumerator Routine()
        {
            var builds = new List<IModuleBuild>();

            for (int i = 0; i < Infos.Count; i++)
            {
                IModuleBuildInfo info = Infos[i];

                if (info.Active)
                {
                    ResourceRequest operation = Resources.LoadAsync<ModuleBuilderAsset>(info.BuilderId);

                    yield return operation;

                    var builderAsset = (ModuleBuilderAsset)operation.asset;
                    IModuleBuilder builder = builderAsset.GetBuilder();

                    if (builder == null)
                    {
                        throw new ArgumentNullException(nameof(builderAsset.GetBuilder), $"Failed to get builder from the specified builder asset: '{builderAsset}'.");
                    }

                    var arguments = new ModuleBuildArguments<IDescription>();

                    foreach (string id in info.Arguments)
                    {
                        operation = Resources.LoadAsync<DescriptionAsset>(id);

                        yield return operation;

                        var asset = (DescriptionAsset)operation.asset;
                        IDescription description = asset.GetDescription();

                        if (description == null)
                        {
                            throw new ArgumentNullException(nameof(description), $"Failed to get description from the specified description asset: '{asset}'.");
                        }

                        arguments.Values.Add(description);
                    }

                    var build = new ModuleBuild(builder, arguments);

                    builds.Add(build);
                }
            }

            Result = new ReadOnlyCollection<IModuleBuild>(builds);
        }
    }
}
