using System;
using System.Collections;
using System.Runtime.InteropServices;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Addressable.Runtime.Coroutines;
using UGF.Module.Coroutines.Runtime;
using UGF.Module.Scenes.Runtime;
using UnityEngine;
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

        [StructLayout(LayoutKind.Explicit)]
        private struct SceneInstanceConverter
        {
            [FieldOffset(0)] public SceneInstance SceneInstance;
            [FieldOffset(0)] public SceneInstanceInfo SceneInstanceInfo;
        }

        private struct SceneInstanceInfo
        {
            public Scene Scene;
            public AsyncOperation AsyncOperation;
        }

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

            SceneInstance sceneInstance = GetSceneInstance(scene);
            AsyncOperationHandle<SceneInstance> handler = Addressables.UnloadSceneAsync(sceneInstance);
            var coroutine = new OperationHandleCoroutine<SceneInstance>(handler);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }

        private static SceneInstance GetSceneInstance(Scene scene)
        {
            var info = new SceneInstanceInfo { Scene = scene, AsyncOperation = null };
            var converter = new SceneInstanceConverter { SceneInstanceInfo = info };

            return converter.SceneInstance;
        }
    }
}
