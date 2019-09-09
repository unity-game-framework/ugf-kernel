using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Kernel.Runtime
{
    public interface IKernelModuleDescription : IDescription
    {
        int Priority { get; }

        void Initialize(IApplication application);
    }
}
