using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeModuleBuilderAsset", order = 2000)]
    public class SerializeModuleBuilderAsset : ModuleBuilderAsset<ISerializeModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var description = arguments.Get<ISerializeModuleDescription>();

            return new SerializeModule(description);
        }
    }
}
