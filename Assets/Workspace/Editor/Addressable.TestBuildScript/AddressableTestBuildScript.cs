using UnityEditor;
using UnityEditor.AddressableAssets.Build.DataBuilders;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace Workspace.Editor.Addressable.TestBuildScript
{
    [CreateAssetMenu(fileName = "BuildScriptPackedTests.asset", menuName = "Addressable Assets/Data Builders/Packed Mode Tests")]
    public class AddressableTestBuildScript : BuildScriptPackedMode
    {
        public override string Name { get; } = "Packed Mode Tests";

        protected override string ProcessGroup(AddressableAssetGroup assetGroup, AddressableAssetsBuildContext aaContext)
        {
            bool include = IsTestBuild() || !HasTestBuildScheme(assetGroup);

            if (!include)
            {
                Debug.Log($"AddressableAssetGroup excluded from build: '{assetGroup.Name}'.");
            }

            return include ? base.ProcessGroup(assetGroup, aaContext) : string.Empty;
        }

        private static bool HasTestBuildScheme(AddressableAssetGroup assetGroup)
        {
            return assetGroup.Schemas.Exists(x => x is AddressableTestBuildScheme);
        }

        private static bool IsTestBuild()
        {
            return PlayerSettings.productName == "UnityTestFramework";
        }
    }
}
