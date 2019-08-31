using UnityEditor;
using UnityEditor.AddressableAssets.Settings;

namespace Workspace.Editor.Addressable.TestBuildScript
{
    internal static class AddressableTestBuildPreprocessor
    {
        [InitializeOnLoadMethod]
        private static void Initialize()
        {
            BuildPlayerWindow.RegisterBuildPlayerHandler(BuildPlayerHandler);
        }

        private static void BuildPlayerHandler(BuildPlayerOptions options)
        {
            AddressableAssetSettings.BuildPlayerContent();

            BuildPlayerWindow.DefaultBuildMethods.BuildPlayer(options);
        }
    }
}
