using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeModuleBuilderAsset", order = 2000)]
    public class SerializeModuleBuilderAsset : ModuleBuilderAsset
    {
        public override IModuleBuilder GetBuilder()
        {
            return new ModuleBuilderFunc<ISerializeModule>(application => new SerializeModule());
        }
    }
}
