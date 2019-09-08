using JetBrains.Annotations;
using UGF.CustomSettings.Editor;
using UnityEditor;

namespace UGF.Kernel.Editor.Settings
{
    public static class KernelEditorSettings
    {
        public static bool ConfigProvideProjectSettings
        {
            get { return m_settings.Data.ConfigProvideProjectSettings; }
            set
            {
                m_settings.Data.ConfigProvideProjectSettings = value;
                m_settings.Save();
            }
        }

        public static string ConfigResourcesPath
        {
            get { return m_settings.Data.ConfigResourcesPath; }
            set
            {
                m_settings.Data.ConfigResourcesPath = value;
                m_settings.Save();
            }
        }

        private static readonly CustomSettingsEditorPackage<KernelEditorSettingsData> m_settings = new CustomSettingsEditorPackage<KernelEditorSettingsData>("UGF.Kernel", true, "KernelEditorSettings");

        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetSettingsProvider()
        {
            return new CustomSettingsProvider<KernelEditorSettingsData>("Project/UGF/Kernel", m_settings, SettingsScope.Project);
        }
    }
}
