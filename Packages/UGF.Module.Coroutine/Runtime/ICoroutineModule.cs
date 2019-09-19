using System.Collections;
using UGF.Application.Runtime;

namespace UGF.Module.Coroutine.Runtime
{
    public interface ICoroutineModule : IApplicationModule
    {
        void Start(IEnumerator routine);
        void Stop(IEnumerator routine);
    }
}
