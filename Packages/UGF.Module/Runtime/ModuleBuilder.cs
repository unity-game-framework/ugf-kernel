using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilder<TModuleDescription> : IModuleBuilder where TModuleDescription : class, IModuleDescription
    {
        public IApplicationModule Build(IApplication application, IModuleDescription description)
        {
            return Build(application, (TModuleDescription)description);
        }

        protected abstract IApplicationModule Build(IApplication application, TModuleDescription description);
    }
}
