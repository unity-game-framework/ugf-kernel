using UnityEditor.SettingsManagement;
using PackageSettings = UnityEditor.SettingsManagement.Settings;

namespace UGF.Addressable.Editor.Settings
{
    public static class AddressableSettings
    {
        public static PackageSettings Instance { get; } = new PackageSettings("com.ugf.addressable");
        public static bool IncludeTestGroups { get { return m_includeTestGroups; } set { m_includeTestGroups.value = value; } }

        [UserSetting("Build", "Include Test Groups", "Determines whether to include asset groups marked with test group scheme.")]
        private static UserSetting<bool> m_includeTestGroups = new UserSetting<bool>(Instance, "build.includeTestGroups", false);
    }
}
