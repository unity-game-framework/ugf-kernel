using System.Collections;
using UGF.Coroutines.Runtime;
using UGF.Module.Scenes.Runtime;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UGF.Module.Addressable.Runtime.Coroutines
{
    public class OperationHandleSceneCoroutine : Coroutine<Scene>
    {
        public AsyncOperationHandle<SceneInstance> Handle { get { return m_handle; } }
        public SceneLoadParameters Parameters { get; }

        private readonly AsyncOperationHandle<SceneInstance> m_handle;

        public OperationHandleSceneCoroutine(AsyncOperationHandle<SceneInstance> handle, SceneLoadParameters parameters)
        {
            Parameters = parameters;
            m_handle = handle;
        }

        protected override IEnumerator Routine()
        {
            while (!m_handle.IsDone)
            {
                yield return null;
            }

            Result = m_handle.Result.Scene;

            if (Parameters.UnloadUnused)
            {
                yield return Resources.UnloadUnusedAssets();
            }
        }
    }
}
