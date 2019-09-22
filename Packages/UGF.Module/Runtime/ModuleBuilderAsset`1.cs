using System;
using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilderAsset<TRegisterType> : ModuleBuilderAsset where TRegisterType : IApplicationModule
    {
        public override Type RegisterType { get; } = typeof(TRegisterType);

        public override IModuleBuilder GetBuilder()
        {
            return new ModuleBuilderDelegate<TRegisterType>(OnBuild);
        }

        protected abstract IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments);
    }
}
