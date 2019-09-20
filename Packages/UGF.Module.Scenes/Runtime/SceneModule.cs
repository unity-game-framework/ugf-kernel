using System;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Module.Coroutines.Runtime;
using UnityEngine.SceneManagement;

namespace UGF.Module.Scenes.Runtime
{
    public class SceneModule : ApplicationModuleBase, ISceneModule
    {
        public ICoroutineModule CoroutineModule { get; }

        public SceneModule(ICoroutineModule coroutineModule)
        {
            CoroutineModule = coroutineModule;
        }

        public ICoroutine<Scene> LoadSceneAsync(string sceneName, SceneLoadParameters parameters)
        {
            if (sceneName == null) throw new ArgumentNullException(nameof(sceneName));

            var coroutine = new SceneLoadCoroutine(sceneName, parameters);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }

        public ICoroutine UnloadSceneAsync(Scene scene, SceneUnloadParameters parameters)
        {
            if (!scene.IsValid()) throw new ArgumentException("The specified scene not valid.", nameof(scene));

            var coroutine = new SceneUnloadCoroutine(scene, parameters);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }
    }
}
