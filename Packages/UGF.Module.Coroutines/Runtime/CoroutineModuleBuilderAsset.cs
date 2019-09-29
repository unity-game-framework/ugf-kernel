using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Coroutines.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Coroutine/CoroutineModuleBuilder", order = 2000)]
    public class CoroutineModuleBuilderAsset : ModuleBuilderAsset<ICoroutineModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            return new CoroutineModule();
        }
    }
}
