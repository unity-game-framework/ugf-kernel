using System;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelConfigModuleInfo : IKernelConfigModuleInfo
    {
        [SerializeField] private string m_builderId;
        [SerializeField] private string m_descriptionId;

        public string BuilderId { get { return m_builderId; } set { m_builderId = value; } }
        public string DescriptionId { get { return m_descriptionId; } set { m_descriptionId = value; } }
    }
}
