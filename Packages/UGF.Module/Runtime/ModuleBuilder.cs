using System;
using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilder<TRegisterType, TModuleDescription> : IModuleBuilder
        where TRegisterType : IApplicationModule
        where TModuleDescription : class, IModuleDescription
    {
        public Type RegisterType { get; } = typeof(TRegisterType);

        public IApplicationModule Build(IApplication application, IModuleDescription description)
        {
            return Build(application, (TModuleDescription)description);
        }

        protected abstract IApplicationModule Build(IApplication application, TModuleDescription description);
    }
}
