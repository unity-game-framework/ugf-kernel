using UnityEngine;

namespace UGF.Kernel.Runtime.Modules
{
    public abstract class ModuleBuilderAsset : ScriptableObject
    {
        public abstract IModuleBuilder GetBuilder();
    }
}
