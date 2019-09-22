using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Coroutines.Runtime;
using UGF.Description.Runtime;
using UnityEngine;

namespace UGF.Module.Runtime.Coroutines
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

                ResourceRequest operation = Resources.LoadAsync<ModuleBuilderAsset>(info.BuilderId);

                yield return operation;

                var builderAsset = operation.asset as ModuleBuilderAsset;

                if (builderAsset == null)
                {
                    throw new ArgumentNullException(nameof(operation.asset), $"Failed to load specified builder: '{info.BuilderId}'.");
                }

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

                    var asset = operation.asset as DescriptionAsset;

                    if (asset == null)
                    {
                        throw new ArgumentNullException(nameof(operation.asset), $"Failed to load specified description: '{id}'.");
                    }

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

            Result = new ReadOnlyCollection<IModuleBuild>(builds);
        }
    }
}
