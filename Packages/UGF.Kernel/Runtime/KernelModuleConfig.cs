using System;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelModuleConfig : IKernelModuleConfig
    {
        [SerializeField] private string m_builderIdentifier;
        [SerializeField] private string m_descriptionIdentifier;

        public string BuilderIdentifier { get { return m_builderIdentifier; } set { m_builderIdentifier = value; } }
        public string DescriptionIdentifier { get { return m_descriptionIdentifier; } set { m_descriptionIdentifier = value; } }
    }
}
