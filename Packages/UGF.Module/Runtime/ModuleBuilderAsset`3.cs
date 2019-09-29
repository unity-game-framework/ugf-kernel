using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilderAsset<TRegisterType, TDescription0, TDescription1> : ModuleBuilderAsset<TRegisterType>
        where TRegisterType : IApplicationModule
        where TDescription0 : IDescription
        where TDescription1 : IDescription
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var description0 = arguments.Get<TDescription0>();
            var description1 = arguments.Get<TDescription1>();

            return OnBuild(application, description0, description1);
        }

        protected abstract IApplicationModule OnBuild(IApplication application, TDescription0 description0, TDescription1 description1);
    }
}
