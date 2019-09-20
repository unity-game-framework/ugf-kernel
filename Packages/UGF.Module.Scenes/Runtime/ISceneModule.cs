using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UnityEngine.SceneManagement;

namespace UGF.Module.Scenes.Runtime
{
    public interface ISceneModule : IApplicationModule
    {
        ICoroutine<Scene> LoadSceneAsync(string sceneName, SceneLoadParameters parameters);
        ICoroutine UnloadSceneAsync(Scene scene, SceneUnloadParameters parameters);
    }
}
