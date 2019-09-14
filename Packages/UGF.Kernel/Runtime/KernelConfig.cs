using System;
using System.Collections.Generic;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelConfig : IKernelConfig
    {
        [SerializeField] private string m_name = "Default";
        [SerializeField] private List<KernelConfigModuleInfo> m_modules = new List<KernelConfigModuleInfo>();

        public string Name { get { return m_name; } set { m_name = value; } }
        public List<KernelConfigModuleInfo> Modules { get { return m_modules; } set { m_modules = value; } }

        IReadOnlyList<IKernelConfigModuleInfo> IKernelConfig.Modules { get { return m_modules; } }
    }
}
