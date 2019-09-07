using UnityEngine;

namespace UGF.Kernel.Editor.Settings
{
    internal class KernelEditorSettingsData : ScriptableObject
    {
        [SerializeField] private bool m_configProvideProjectSettings = true;
        [SerializeField] private string m_configResourcesPath = "Config";

        public bool ConfigProvideProjectSettings { get { return m_configProvideProjectSettings; } set { m_configProvideProjectSettings = value; } }
        public string ConfigResourcesPath { get { return m_configResourcesPath; } set { m_configResourcesPath = value; } }
    }
}
