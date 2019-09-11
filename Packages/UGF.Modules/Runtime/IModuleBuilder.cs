using UGF.Application.Runtime;

namespace UGF.Modules.Runtime
{
    public interface IModuleBuilder
    {
        IApplicationModule Build(IApplication application, IModuleDescription description);
    }
}
