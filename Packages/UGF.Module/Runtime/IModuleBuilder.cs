using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public interface IModuleBuilder
    {
        IApplicationModule Build(IApplication application, IModuleDescription description);
    }
}
