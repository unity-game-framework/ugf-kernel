using UnityEngine;

namespace UGF.Modules.Runtime
{
    public abstract class ModuleBuilderAsset : ScriptableObject
    {
        public abstract IModuleBuilder GetBuilder();
    }
}
