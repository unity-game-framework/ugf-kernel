using UnityEditor.AddressableAssets.Build.DataBuilders;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace Workspace.Editor
{
    [CreateAssetMenu(fileName = "BuildScriptPackedTests.asset", menuName = "Addressable Assets/Data Builders/Packed Mode Tests")]
    public class AddressableTestBuildScript : BuildScriptPackedMode
    {
        public override string Name { get; } = "Packed Mode Tests";

        protected override string ProcessGroup(AddressableAssetGroup assetGroup, AddressableAssetsBuildContext aaContext)
        {
            return !assetGroup.Schemas.Exists(x => x is AddressableTestBuildScheme) ? base.ProcessGroup(assetGroup, aaContext) : string.Empty;
        }
    }
}
