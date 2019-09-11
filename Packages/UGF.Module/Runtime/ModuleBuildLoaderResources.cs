using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Description.Runtime;
using UnityEngine;

namespace UGF.Module.Runtime
{
    public class ModuleBuildLoaderResources : IModuleBuildLoader
    {
        public IEnumerator LoadAsync(ICollection<ModuleBuild> builds, IReadOnlyList<ModuleInfo> infos)
        {
            for (int i = 0; i < infos.Count; i++)
            {
                ModuleInfo info = infos[i];

                ResourceRequest operation = Resources.LoadAsync<ModuleBuilderAsset>(info.BuilderId);

                yield return operation;

                ModuleBuilderAsset builderAsset = operation.asset as ModuleBuilderAsset ?? throw new ArgumentNullException(nameof(operation.asset));
                IModuleBuilder builder = builderAsset.GetBuilder() ?? throw new ArgumentNullException(nameof(builderAsset.GetBuilder));

                operation = Resources.LoadAsync<DescriptionAsset>(info.DescriptionId);

                yield return operation;

                DescriptionAsset descriptionAsset = operation.asset as DescriptionAsset ?? throw new ArgumentNullException(nameof(operation.asset));
                IModuleDescription description = descriptionAsset.GetDescription<IModuleDescription>() ?? throw new ArgumentNullException(nameof(descriptionAsset.GetDescription));

                var build = new ModuleBuild(builder, description);

                builds.Add(build);
            }
        }
    }
}
