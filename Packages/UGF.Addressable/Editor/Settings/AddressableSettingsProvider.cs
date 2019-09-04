using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.SettingsManagement;

namespace UGF.Addressable.Editor.Settings
{
    internal static class AddressableSettingsProvider
    {
        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider Create()
        {
            return new UserSettingsProvider("Project/UGF/Addressables", AddressableSettings.Instance, new[] { typeof(AddressableSettings).Assembly }, SettingsScope.Project);
        }
    }
}
