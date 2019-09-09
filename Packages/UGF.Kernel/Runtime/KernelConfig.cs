using System;
using System.Collections.Generic;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelConfig : IKernelConfig
    {
        [SerializeField] private string m_name = "Default";
        [SerializeField] private List<KernelConfigModule> m_modules = new List<KernelConfigModule>();

        public string Name { get { return m_name; } set { m_name = value; } }
        public List<KernelConfigModule> Modules { get { return m_modules; } }

        IEnumerable<IKernelConfigModule> IKernelConfig.Modules { get { return m_modules; } }
    }
}
