using System;
using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilder<TRegisterType> : IModuleBuilder where TRegisterType : IApplicationModule
    {
        public Type RegisterType { get; } = typeof(TRegisterType);

        public IApplicationModule Build(IApplication application)
        {
            if (application == null) throw new ArgumentNullException(nameof(application));

            return OnBuild(application);
        }

        public IApplicationModule Build(IApplication application, IModuleDescription description)
        {
            if (application == null) throw new ArgumentNullException(nameof(application));
            if (description == null) throw new ArgumentNullException(nameof(description));

            return OnBuild(application, description);
        }

        protected abstract IApplicationModule OnBuild(IApplication application);
        protected abstract IApplicationModule OnBuild(IApplication application, IModuleDescription description);
    }
}
