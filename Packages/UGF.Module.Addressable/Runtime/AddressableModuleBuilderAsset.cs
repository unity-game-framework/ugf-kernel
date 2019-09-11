using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Addressable.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module/AddressableModuleBuilderAsset", order = 2000)]
    public class AddressableModuleBuilderAsset : ModuleBuilderAsset
    {
        public override IModuleBuilder GetBuilder()
        {
            return new ModuleBuilderFunc<AddressableModuleDescription>((application, description) => new AddressableModule(description));
        }
    }
}
