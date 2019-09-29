using System;
using UnityEngine;

namespace UGF.Module.Runtime
{
    public abstract class ModuleBuilderAsset : ScriptableObject
    {
        public abstract Type RegisterType { get; }

        public abstract IModuleBuilder GetBuilder();
    }
}
