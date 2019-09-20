using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Assets.Runtime;
using UGF.Module.Coroutines.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Addressable.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Addressable/AddressableAssetsModuleBuilderAsset", order = 2000)]
    public class AddressableAssetsModuleBuilderAsset : ModuleBuilderAsset<IAssetsModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var coroutineModule = application.GetModule<ICoroutineModule>();

            return new AddressableAssetsModule(coroutineModule);
        }
    }
}
