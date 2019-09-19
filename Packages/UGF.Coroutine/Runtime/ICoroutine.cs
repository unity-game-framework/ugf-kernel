using System.Collections;

namespace UGF.Coroutine.Runtime
{
    public interface ICoroutine : IEnumerator
    {
        bool IsCompleted { get; }

        event CoroutineHandler Completed;

        T GetResult<T>();
        object GetResult();
    }
}
