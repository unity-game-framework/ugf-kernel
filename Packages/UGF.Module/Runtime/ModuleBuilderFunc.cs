using System;
using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public class ModuleBuilderFunc<TRegisterType> : ModuleBuilder<TRegisterType> where TRegisterType : IApplicationModule
    {
        public Func<IApplication, IModuleBuildArguments<IDescription>, IApplicationModule> Func { get; }

        public ModuleBuilderFunc(Func<IApplication, IModuleBuildArguments<IDescription>, IApplicationModule> func)
        {
            Func = func ?? throw new ArgumentNullException(nameof(func));
        }

        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            return Func(application, arguments);
        }
    }
}
