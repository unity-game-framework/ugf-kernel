using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Description.Runtime;
using UnityEngine;

namespace UGF.Module.Runtime
{
    public class ModuleBuildLoaderResources : IModuleBuildLoader
    {
        public IEnumerator LoadAsync(ICollection<IModuleBuild> builds, IReadOnlyList<IModuleBuildInfo> infos)
        {
            for (int i = 0; i < infos.Count; i++)
            {
                IModuleBuildInfo info = infos[i];

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
        }
    }
}
