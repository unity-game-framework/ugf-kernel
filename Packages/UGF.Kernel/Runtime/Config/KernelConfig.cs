using System;
using UnityEngine;

namespace UGF.Kernel.Runtime.Config
{
    [Serializable]
    public class KernelConfig : IKernelConfig
    {
        [SerializeField] private string m_name = "default";

        public string Name { get { return m_name; } set { m_name = value; } }
    }
}
