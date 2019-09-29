using UGF.Application.Runtime;
using UGF.Module.Runtime;
using UGF.Module.Serialize.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeUtf8JsonModuleBuilder", order = 2000)]
    public class SerializeUtf8JsonModuleBuilderAsset : ModuleBuilderAsset<ISerializeUtf8JsonModule, ISerializeUtf8JsonModuleDescription>
    {
        protected override IApplicationModule OnBuild(IApplication application, ISerializeUtf8JsonModuleDescription description)
        {
            var serializeModule = application.GetModule<ISerializeModule>();

            return new SerializeUtf8JsonModule(application, serializeModule, description);
        }
    }
}
