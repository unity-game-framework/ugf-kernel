using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Coroutines.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Assets.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Assets/AssetsResourcesModuleBuilderAsset", order = 2000)]
    public class AssetsResourcesModuleBuilderAsset : ModuleBuilderAsset<IAssetsModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var coroutineModule = application.GetModule<ICoroutineModule>();

            return new AssetsResourcesModule(coroutineModule);
        }
    }
}
