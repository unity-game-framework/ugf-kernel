using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilder<TRegisterType, TModuleDescription> : ModuleBuilder<TRegisterType>
        where TRegisterType : IApplicationModule
        where TModuleDescription : IModuleDescription
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleDescription description)
        {
            return OnBuild(application, (TModuleDescription)description);
        }

        protected abstract IApplicationModule OnBuild(IApplication application, TModuleDescription description);
    }
}
