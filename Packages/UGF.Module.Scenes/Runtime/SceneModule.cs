using System;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Module.Scenes.Runtime.Coroutines;
using UnityEngine.SceneManagement;

namespace UGF.Module.Scenes.Runtime
{
    public class SceneModule : ApplicationModuleBase, ISceneModule
    {
        public ISceneLoadCoroutine LoadSceneAsync(string sceneName, SceneLoadParameters parameters)
        {
            if (sceneName == null) throw new ArgumentNullException(nameof(sceneName));

            return new SceneLoadCoroutine(sceneName, parameters);
        }

        public ICoroutine UnloadSceneAsync(Scene scene, SceneUnloadParameters parameters)
        {
            if (!scene.IsValid()) throw new ArgumentException("The specified scene is invalid.", nameof(scene));

            return new SceneUnloadCoroutine(scene, parameters);
        }
    }
}
