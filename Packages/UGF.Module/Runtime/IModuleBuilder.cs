using System;
using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public interface IModuleBuilder
    {
        Type RegisterType { get; }

        IApplicationModule Build(IApplication application, IModuleBuildArguments<IDescription> arguments);
    }
}
