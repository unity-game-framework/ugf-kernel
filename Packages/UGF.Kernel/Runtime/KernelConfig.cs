using System;
using System.Collections.Generic;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelConfig : IKernelConfig
    {
        [SerializeField] private string m_name = "Default";
        [SerializeField] private List<ModuleInfo> m_modules = new List<ModuleInfo>();

        public string Name { get { return m_name; } set { m_name = value; } }
        public List<ModuleInfo> Modules { get { return m_modules; } set { m_modules = value; } }

        IReadOnlyList<ModuleInfo> IKernelConfig.Modules { get { return m_modules; } }
    }
}
