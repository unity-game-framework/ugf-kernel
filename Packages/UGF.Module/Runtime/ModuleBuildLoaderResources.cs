using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Description.Runtime;
using UnityEngine;

namespace UGF.Module.Runtime
{
    public class ModuleBuildLoaderResources : IModuleBuildLoader
    {
        public IEnumerator LoadAsync(ICollection<ModuleBuild> builds, IReadOnlyList<ModuleBuildInfo> infos)
        {
            for (int i = 0; i < infos.Count; i++)
            {
                ModuleBuildInfo info = infos[i];

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

                IModuleDescription description = null;

                if (info.HasDescription)
                {
                    operation = Resources.LoadAsync<DescriptionAsset>(info.DescriptionId);

                    yield return operation;

                    var descriptionAsset = operation.asset as DescriptionAsset;

                    if (descriptionAsset == null)
                    {
                        throw new ArgumentNullException(nameof(operation.asset), $"Failed to load specified description: '{info.DescriptionId}'.");
                    }

                    description = descriptionAsset.GetDescription<IModuleDescription>();

                    if (description == null)
                    {
                        throw new ArgumentNullException(nameof(descriptionAsset.GetDescription), $"Failed to get description from the specified description asset: '{descriptionAsset}'.");
                    }
                }

                var build = new ModuleBuild(builder, description);

                builds.Add(build);
            }
        }
    }
}
