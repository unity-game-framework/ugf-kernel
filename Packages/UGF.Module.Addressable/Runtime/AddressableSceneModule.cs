using System;
using System.Collections;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Addressable.Runtime.Coroutines;
using UGF.Module.Coroutines.Runtime;
using UGF.Module.Scenes.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UGF.Module.Addressable.Runtime
{
    public class AddressableSceneModule : ApplicationModuleBaseAsync, ISceneModule
    {
        public ICoroutineModule CoroutineModule { get; }

        public AddressableSceneModule(ICoroutineModule coroutineModule)
        {
            CoroutineModule = coroutineModule ?? throw new ArgumentNullException(nameof(coroutineModule));
        }

        protected override IEnumerator OnInitializeAsync()
        {
            AsyncOperationHandle<IResourceLocator> operation = Addressables.InitializeAsync();

            while (!operation.IsDone)
            {
                yield return null;
            }

            Log.Debug($"AddressableSceneModule initialized: locators:'{Addressables.ResourceLocators.Count}', runtimePath:'{Addressables.RuntimePath}'.");
        }

        public ISceneLoadCoroutine LoadSceneAsync(string sceneName, SceneLoadParameters parameters)
        {
            if (sceneName == null) throw new ArgumentNullException(nameof(sceneName));

            AsyncOperationHandle<SceneInstance> handler = Addressables.LoadSceneAsync(sceneName, parameters.Mode, parameters.Activate);
            var coroutine = new OperationHandleSceneCoroutine(handler, parameters);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }

        public ICoroutine UnloadSceneAsync(Scene scene, SceneUnloadParameters parameters)
        {
            if (!scene.IsValid()) throw new ArgumentException("The specified scene is invalid.", nameof(scene));

            throw new NotSupportedException("Unloading scene without 'SceneInstance' not supported in Addressables.");
        }
    }
}
