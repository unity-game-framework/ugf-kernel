using System.Collections;

namespace UGF.Kernel.Runtime
{
    public interface IKernelConfigLoader
    {
        IEnumerator Load();
        IKernelConfig GetResult();
    }
}
