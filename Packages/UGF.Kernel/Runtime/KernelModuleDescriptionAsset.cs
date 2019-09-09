using UGF.Description.Runtime;

namespace UGF.Kernel.Runtime
{
    public abstract class KernelModuleDescriptionAsset<TDescription> : DescriptionAsset<TDescription> where TDescription : IKernelModuleDescription
    {
    }
}
