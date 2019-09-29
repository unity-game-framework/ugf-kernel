using System;
using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public class ModuleBuilderDelegate<TRegisterType> : ModuleBuilder<TRegisterType> where TRegisterType : IApplicationModule
    {
        public ModuleBuilderHandler Handler { get; }

        public ModuleBuilderDelegate(ModuleBuilderHandler handler)
        {
            Handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            return Handler(application, arguments);
        }
    }
}
