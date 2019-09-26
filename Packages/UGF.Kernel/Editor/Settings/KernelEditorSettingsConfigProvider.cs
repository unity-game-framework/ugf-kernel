using JetBrains.Annotations;
using UGF.Kernel.Runtime;
using UnityEditor;

namespace UGF.Kernel.Editor.Settings
{
    internal static class KernelEditorSettingsConfigProvider
    {
        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetSettingsProvider()
        {
            if (KernelEditorUserSettings.ShowConfigInProjectSettings)
            {
                KernelConfigAsset asset = KernelEditorUserSettings.ProjectSettingsConfig;

                if (asset != null)
                {
                    return AssetSettingsProvider.CreateProviderFromObject("Project/UGF/Kernel Config", asset);
                }
            }

            return null;
        }
    }
}
