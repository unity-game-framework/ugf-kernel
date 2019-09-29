using System;
using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilder<TRegisterType> : IModuleBuilder where TRegisterType : IApplicationModule
    {
        public Type RegisterType { get; } = typeof(TRegisterType);

        public IApplicationModule Build(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            if (application == null) throw new ArgumentNullException(nameof(application));
            if (arguments == null) throw new ArgumentNullException(nameof(arguments));

            return OnBuild(application, arguments);
        }

        protected abstract IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments);
    }
}
