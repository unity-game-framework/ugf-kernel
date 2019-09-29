using UGF.Application.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeModuleBuilder", order = 2000)]
    public class SerializeModuleBuilderAsset : ModuleBuilderAsset<ISerializeModule, ISerializeModuleDescription>
    {
        protected override IApplicationModule OnBuild(IApplication application, ISerializeModuleDescription description)
        {
            return new SerializeModule(description);
        }
    }
}
