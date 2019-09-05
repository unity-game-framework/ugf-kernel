using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.SettingsManagement;
using PackageSettings = UnityEditor.SettingsManagement.Settings;

namespace UGF.Kernel.Editor.Settings
{
    public static class KernelUserEditorSettings
    {
        public static bool ConfigProvideProjectSettings { get { return m_configProvideProjectSettings; } set { m_configProvideProjectSettings.value = value; } }
        public static string ConfigResourcesPath { get { return m_configPath; } set { m_configPath.value = value; } }

        private static readonly PackageSettings m_instance = new PackageSettings(new[] { new UserSettingsRepository() });

        [UserSetting("Config Project Settings", "Provide Project Settings Tab", "")]
        private static readonly UserSetting<bool> m_configProvideProjectSettings = new UserSetting<bool>(m_instance, "config.provideProjectSettings", true, SettingsScope.User);

        [UserSetting("Config Project Settings", "Config Resources Path", "")]
        private static readonly UserSetting<string> m_configPath = new UserSetting<string>(m_instance, "config.path", "Config", SettingsScope.User);

        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetProvider()
        {
            return new UserSettingsProvider("Preferences/UGF/Kernel", m_instance, new[] { typeof(KernelUserEditorSettings).Assembly });
        }
    }
}
