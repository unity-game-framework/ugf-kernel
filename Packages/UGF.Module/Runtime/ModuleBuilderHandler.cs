using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public delegate IApplicationModule ModuleBuilderHandler(IApplication application, IModuleBuildArguments<IDescription> arguments);
}
