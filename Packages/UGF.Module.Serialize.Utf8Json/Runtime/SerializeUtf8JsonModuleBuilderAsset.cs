using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeUtf8JsonModuleBuilderAsset", order = 2000)]
    public class SerializeUtf8JsonModuleBuilderAsset : ModuleBuilderAsset<ISerializeUtf8JsonModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var description = arguments.Get<ISerializeUtf8JsonModuleDescription>();

            return new SerializeUtf8JsonModule(application, description);
        }
    }
}
