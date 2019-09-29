using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Coroutines.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UGF.Module.Addressable.Runtime.Coroutines
{
    public class LoadModuleBuildsAddressableCoroutine : Coroutine<IReadOnlyList<IModuleBuild>>
    {
        public IReadOnlyList<IModuleBuildInfo> Infos { get; }

        public LoadModuleBuildsAddressableCoroutine(IReadOnlyList<IModuleBuildInfo> infos)
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
                    AsyncOperationHandle<ModuleBuilderAsset> builderHandle = Addressables.LoadAssetAsync<ModuleBuilderAsset>(info.BuilderId);

                    while (!builderHandle.IsDone)
                    {
                        yield return null;
                    }

                    IModuleBuilder builder = builderHandle.Result.GetBuilder();
                    var arguments = new ModuleBuildArguments<IDescription>();

                    foreach (string id in info.Arguments)
                    {
                        AsyncOperationHandle<DescriptionAsset> argumentHandle = Addressables.LoadAssetAsync<DescriptionAsset>(id);

                        while (!argumentHandle.IsDone)
                        {
                            yield return null;
                        }

                        IDescription description = argumentHandle.Result.GetDescription();

                        arguments.Values.Add(description);

                        Addressables.Release(argumentHandle);
                    }

                    var build = new ModuleBuild(builder, arguments);

                    builds.Add(build);

                    Addressables.Release(builderHandle);
                }
            }

            Result = new ReadOnlyCollection<IModuleBuild>(builds);
        }
    }
}
