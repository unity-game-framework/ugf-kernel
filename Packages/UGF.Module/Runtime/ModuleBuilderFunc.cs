using System;
using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public class ModuleBuilderFunc<TRegisterType, TModuleDescription> : ModuleBuilder<TRegisterType, TModuleDescription>
        where TRegisterType : IApplicationModule
        where TModuleDescription : class, IModuleDescription
    {
        public Func<IApplication, TModuleDescription, IApplicationModule> Func { get; }

        public ModuleBuilderFunc(Func<IApplication, TModuleDescription, IApplicationModule> func)
        {
            Func = func;
        }

        protected override IApplicationModule Build(IApplication application, TModuleDescription description)
        {
            return Func(application, description);
        }
    }
}
