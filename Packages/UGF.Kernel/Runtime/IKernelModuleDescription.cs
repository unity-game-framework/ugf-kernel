using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Kernel.Runtime
{
    public interface IKernelModuleDescription : IDescription
    {
        void Initialize(IApplication application);
    }
}
