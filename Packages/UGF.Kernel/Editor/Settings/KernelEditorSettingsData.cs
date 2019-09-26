using UGF.Kernel.Runtime;
using UnityEngine;

namespace UGF.Kernel.Editor.Settings
{
    internal class KernelEditorSettingsData : ScriptableObject
    {
        [SerializeField] private bool m_showConfigInProjectSettings = true;
        [SerializeField] private KernelConfigAsset m_projectSettingsConfig;

        public bool ShowConfigInProjectSettings { get { return m_showConfigInProjectSettings; } set { m_showConfigInProjectSettings = value; } }
        public KernelConfigAsset ProjectSettingsConfig { get { return m_projectSettingsConfig; } set { m_projectSettingsConfig = value; } }
    }
}
