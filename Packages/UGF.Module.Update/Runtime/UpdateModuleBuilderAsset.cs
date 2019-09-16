using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Update.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Update/UpdateModuleBuilderAsset", order = 2000)]
    public class UpdateModuleBuilderAsset : ModuleBuilderAsset<IUpdateModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            return new UpdateModule();
        }
    }
}
