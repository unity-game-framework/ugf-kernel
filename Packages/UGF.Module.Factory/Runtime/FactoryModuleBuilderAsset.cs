using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Factory.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Factory/FactoryModuleBuilderAsset", order = 2000)]
    public class FactoryModuleBuilderAsset : ModuleBuilderAsset<IFactoryModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            return new FactoryModule();
        }
    }
}
