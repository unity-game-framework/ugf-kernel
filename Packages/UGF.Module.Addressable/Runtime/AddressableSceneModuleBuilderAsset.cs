using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UGF.Module.Scenes.Runtime;
using UnityEngine;

namespace UGF.Module.Addressable.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Addressable/AddressableSceneModuleBuilderAsset", order = 2000)]
    public class AddressableSceneModuleBuilderAsset : ModuleBuilderAsset<ISceneModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            return new AddressableSceneModule();
        }
    }
}
