using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Assets.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Descriptions.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Descriptions/DescriptionModuleBuilderAsset", order = 2000)]
    public class DescriptionModuleBuilderAsset : ModuleBuilderAsset<DescriptionModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var description = arguments.Get<IDescriptionModuleDescription>();
            var assetsModule = application.GetModule<IAssetsModule>();

            return new DescriptionModule(description, assetsModule);
        }
    }
}
