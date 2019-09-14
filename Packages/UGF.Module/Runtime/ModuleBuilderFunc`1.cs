using System;
using UGF.Application.Runtime;

namespace UGF.Module.Runtime
{
    public class ModuleBuilderFunc<TRegisterType> : ModuleBuilder<TRegisterType> where TRegisterType : IApplicationModule
    {
        public Func<IApplication, IApplicationModule> Func { get; }

        public ModuleBuilderFunc(Func<IApplication, IApplicationModule> func)
        {
            Func = func;
        }

        protected override IApplicationModule OnBuild(IApplication application)
        {
            return Func(application);
        }

        protected override IApplicationModule OnBuild(IApplication application, IModuleDescription description)
        {
            throw new NotSupportedException($"Build '{typeof(TRegisterType)}' with description not supported.");
        }
    }
}
