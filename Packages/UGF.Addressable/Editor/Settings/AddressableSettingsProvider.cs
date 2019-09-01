using UnityEditor;
using UnityEditor.SettingsManagement;

namespace UGF.Addressable.Editor.Settings
{
    internal static class AddressableSettingsProvider
    {
        [SettingsProvider]
        private static SettingsProvider Create()
        {
            return new UserSettingsProvider("Project/UGF/Addressables", AddressableSettings.Instance, new[] { typeof(AddressableSettings).Assembly }, SettingsScope.Project);
        }
    }
}
