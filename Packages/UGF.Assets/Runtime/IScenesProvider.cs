using UGF.Coroutines.Runtime;
using UnityEngine.SceneManagement;

namespace UGF.Assets.Runtime
{
    public interface IScenesProvider
    {
        Scene LoadScene(string sceneName);
        ICoroutine<Scene> LoadSceneAsync(string sceneName);
        void UnloadScene(Scene scene);
        ICoroutine<Scene> UnloadSceneAsync(Scene scene);
    }
}
