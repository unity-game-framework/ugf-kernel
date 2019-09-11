using System;
using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public class ModuleBuilderFunc<TModuleDescription> : ModuleBuilder<TModuleDescription> where TModuleDescription : class, IModuleDescription
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
