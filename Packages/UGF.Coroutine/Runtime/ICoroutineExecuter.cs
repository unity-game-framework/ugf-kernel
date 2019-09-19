using System.Collections;

namespace UGF.Coroutine.Runtime
{
    public interface ICoroutineExecuter
    {
        void Start(IEnumerator routine);
        void Stop(IEnumerator routine);
    }
}
