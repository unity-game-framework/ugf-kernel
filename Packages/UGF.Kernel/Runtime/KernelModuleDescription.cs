using UGF.Application.Runtime;

namespace UGF.Kernel.Runtime
{
    public abstract class KernelModuleDescription : IKernelModuleDescription
    {
        public abstract void Initialize(IApplication application);
    }
}
