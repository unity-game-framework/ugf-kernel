using JetBrains.Annotations;
using UnityEditor;

namespace UGF.Kernel.Editor.Settings
{
    internal static class KernelEditorSettingsConfigProvider
    {
        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetSettingsProvider()
        {
            return KernelEditorSettings.ConfigProvideProjectSettings
                ? AssetSettingsProvider.CreateProviderFromResourcePath("Project/UGF/Kernel Config", KernelEditorSettings.ConfigResourcesPath)
                : null;
        }
    }
}
