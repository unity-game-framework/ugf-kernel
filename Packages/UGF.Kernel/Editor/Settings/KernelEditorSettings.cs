using JetBrains.Annotations;
using UGF.CustomSettings.Editor;
using UGF.Kernel.Runtime;
using UnityEditor;

namespace UGF.Kernel.Editor.Settings
{
    public static class KernelEditorUserSettings
    {
        public static bool ShowConfigInProjectSettings
        {
            get { return m_settings.Data.ShowConfigInProjectSettings; }
            set
            {
                m_settings.Data.ShowConfigInProjectSettings = value;
                m_settings.Save();
            }
        }

        public static KernelConfigAsset ProjectSettingsConfig
        {
            get { return m_settings.Data.ProjectSettingsConfig; }
            set
            {
                m_settings.Data.ProjectSettingsConfig = value;
                m_settings.Save();
            }
        }

        private static readonly CustomSettingsEditorPrefs<KernelEditorSettingsData> m_settings = new CustomSettingsEditorPrefs<KernelEditorSettingsData>
        (
            "Packages.UGF.Kernel.KernelEditorSettings"
        );

        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetSettingsProvider()
        {
            return new CustomSettingsProvider<KernelEditorSettingsData>("Preferences/UGF/Kernel", m_settings, SettingsScope.User);
        }
    }
}
