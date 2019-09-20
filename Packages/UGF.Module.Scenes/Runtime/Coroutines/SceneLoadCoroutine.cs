using System.Collections;
using UGF.Coroutines.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UGF.Module.Scenes.Runtime.Coroutines
{
    public class SceneLoadCoroutine : Coroutine<Scene>
    {
        public string SceneName { get; }
        public SceneLoadParameters Parameters { get; }

        public SceneLoadCoroutine(string sceneName, SceneLoadParameters parameters)
        {
            SceneName = sceneName;
            Parameters = parameters;
        }

        protected override IEnumerator Routine()
        {
            var parameters = new LoadSceneParameters(Parameters.Mode, Parameters.PhysicsMode);

            AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName, parameters);

            operation.allowSceneActivation = Parameters.Activate;

            yield return operation;

            Result = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);

            if (Parameters.UnloadUnused)
            {
                yield return Resources.UnloadUnusedAssets();
            }
        }
    }
}
