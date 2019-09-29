using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Scenes.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Scenes/SceneModuleBuilder", order = 2000)]
    public class SceneModuleBuilderAsset : ModuleBuilderAsset<ISceneModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            return new SceneModule();
        }
    }
}
