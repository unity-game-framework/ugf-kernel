using UGF.Application.Runtime;

namespace UGF.Kernel.Runtime.Modules
{
    public interface IModuleBuilder
    {
        IApplicationModule Build(IApplication application, IModuleDescription description);
    }
}
