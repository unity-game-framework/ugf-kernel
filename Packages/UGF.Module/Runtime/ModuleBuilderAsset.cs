using UnityEngine;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilderAsset : ScriptableObject
    {
        public abstract IModuleBuilder GetBuilder();
    }
}
