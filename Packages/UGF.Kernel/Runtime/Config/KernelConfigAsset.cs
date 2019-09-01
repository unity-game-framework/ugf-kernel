using UnityEngine;

namespace UGF.Kernel.Runtime.Config
{
    [CreateAssetMenu(menuName = "UGF/Kernel/KernelConfigAsset", order = 2000)]
    public class KernelConfigAsset : ScriptableObject
    {
        [SerializeField] private KernelConfig m_config = new KernelConfig();

        public KernelConfig Config { get { return m_config; } set { m_config = value; } }
    }
}
