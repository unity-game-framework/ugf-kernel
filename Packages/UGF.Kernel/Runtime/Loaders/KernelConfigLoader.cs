using UGF.Coroutines.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime.Loaders
{
    public abstract class KernelConfigLoader : MonoBehaviour, IKernelConfigLoader
    {
        public abstract ICoroutine<IKernelConfig> Load();
    }
}
