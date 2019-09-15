using UGF.Application.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeUtf8JsonModuleBuilderAsset", order = 2000)]
    public class SerializeUtf8JsonModuleBuilderAsset : ModuleBuilderAsset
    {
        public override IModuleBuilder GetBuilder()
        {
            return new ModuleBuilderFunc<IApplicationModule>((application, arguments) => new SerializeUtf8JsonModule(application));
        }
    }
}
