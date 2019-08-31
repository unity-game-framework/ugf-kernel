using UnityEditor;
using UnityEditor.AddressableAssets.Settings;

namespace Workspace.Editor.Addressable.TestBuildScript
{
    public class AddressableTestBuildScheme : AddressableAssetGroupSchema
    {
        public override void OnGUI()
        {
            base.OnGUI();

            EditorGUILayout.HelpBox("This group marked as test and will be included only in Test build.", MessageType.Info);
        }
    }
}
