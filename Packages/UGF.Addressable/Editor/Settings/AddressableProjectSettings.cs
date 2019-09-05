using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.SettingsManagement;
using PackageSettings = UnityEditor.SettingsManagement.Settings;

namespace UGF.Addressable.Editor.Settings
{
    /// <summary>
    /// Represents project scoped settings for Addressable.
    /// </summary>
    public static class AddressableProjectSettings
    {
        /// <summary>
        /// Gets instance of the settings which stores serialized data.
        /// </summary>
        public static PackageSettings Instance { get; } = new PackageSettings("com.ugf.addressable");

        /// <summary>
        /// Gets or sets value that determines whether to include asset groups with '<see cref="UGF.Addressable.Editor.Scheme.IncludeWithTestsGroupScheme"/>' scheme.
        /// </summary>
        public static bool IncludeTestGroups { get { return m_includeTestGroups; } set { m_includeTestGroups.value = value; } }

        [UserSetting("Build", "Include Test Groups", "Determines whether to include asset groups marked with test group scheme.")]
        private static readonly UserSetting<bool> m_includeTestGroups = new UserSetting<bool>(Instance, "build.includeTestGroups", false);

        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider Create()
        {
            return new UserSettingsProvider("Project/UGF/Addressables", Instance, new[] { Instance.GetType().Assembly }, SettingsScope.Project);
        }
    }
}
