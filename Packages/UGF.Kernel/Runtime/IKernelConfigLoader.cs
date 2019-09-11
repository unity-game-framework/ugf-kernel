using System.Collections;

namespace UGF.Kernel.Runtime
{
    public interface IKernelConfigLoader
    {
        IEnumerator LoadAsync(string configId);
        IKernelConfig GetResult();
    }
}
