using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.SettingsManagement;
using PackageSettings = UnityEditor.SettingsManagement.Settings;

namespace UGF.Addressable.Editor.Settings
{
    /// <summary>
    /// Represents project scoped settings for Addressable.
    /// </summary>
    public static class AddressableProjectEditorSettings
    {
        /// <summary>
        /// Gets or sets value that determines whether to include asset groups with '<see cref="UGF.Addressable.Editor.Scheme.IncludeWithTestsGroupScheme"/>' scheme.
        /// </summary>
        public static bool IncludeTestGroups { get { return m_includeTestGroups; } set { m_includeTestGroups.value = value; } }

        private static readonly PackageSettings m_instance = new PackageSettings("com.ugf.addressable");

        [UserSetting("Build", "Include Test Groups", "Determines whether to include asset groups marked with test group scheme.")]
        private static readonly UserSetting<bool> m_includeTestGroups = new UserSetting<bool>(m_instance, "build.includeTestGroups", false);

        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetProvider()
        {
            return new UserSettingsProvider("Project/UGF/Addressables", m_instance, new[] { typeof(AddressableProjectEditorSettings).Assembly }, SettingsScope.Project);
        }
    }
}
