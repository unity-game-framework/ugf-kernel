using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilderAsset<TRegisterType, TDescription> : ModuleBuilderAsset<TRegisterType>
        where TRegisterType : IApplicationModule
        where TDescription : IDescription
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var description = arguments.Get<TDescription>();

            return OnBuild(application, description);
        }

        protected abstract IApplicationModule OnBuild(IApplication application, TDescription description);
    }
}
