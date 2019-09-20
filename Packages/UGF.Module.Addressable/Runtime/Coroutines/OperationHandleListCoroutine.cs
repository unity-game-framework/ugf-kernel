using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Coroutines.Runtime;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UGF.Module.Addressable.Runtime.Coroutines
{
    public class OperationHandleListCoroutine<TObject> : Coroutine<IReadOnlyList<TObject>>
    {
        public AsyncOperationHandle<IList<TObject>> Handle { get { return m_handle; } }

        private readonly AsyncOperationHandle<IList<TObject>> m_handle;

        public OperationHandleListCoroutine(AsyncOperationHandle<IList<TObject>> handle)
        {
            m_handle = handle;
        }

        protected override IEnumerator Routine()
        {
            while (!m_handle.IsDone)
            {
                yield return null;
            }

            Result = new ReadOnlyCollection<TObject>(m_handle.Result);
        }
    }
}
