using JetBrains.Annotations;
using UnityEditor;

namespace UGF.Kernel.Editor.Settings
{
    internal static class KernelProjectSettingsProvider
    {
        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetProvider()
        {
            return KernelUserEditorSettings.ConfigProvideProjectSettings
                ? AssetSettingsProvider.CreateProviderFromResourcePath("Project/UGF/Kernel Config", KernelUserEditorSettings.ConfigResourcesPath)
                : null;
        }
    }
}
