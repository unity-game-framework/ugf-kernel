using UGF.Coroutines.Runtime;

namespace UGF.Kernel.Runtime.Loaders
{
    public interface IKernelConfigLoader
    {
        ICoroutine<IKernelConfig> Load(string configId);
    }
}
