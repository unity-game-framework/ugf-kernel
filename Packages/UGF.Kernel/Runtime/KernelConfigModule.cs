using System;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelConfigModule : IKernelConfigModule
    {
        [SerializeField] private string m_assetPath;

        public string AssetPath { get { return m_assetPath; } set { m_assetPath = value; } }
    }
}
