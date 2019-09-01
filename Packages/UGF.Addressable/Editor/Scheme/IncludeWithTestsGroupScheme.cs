using UGF.Addressable.Editor.Settings;
using UnityEditor;

namespace UGF.Addressable.Editor.Scheme
{
    public class IncludeWithTestsGroupScheme : IncludeGroupSchemeBase
    {
        public override bool IsIncluded()
        {
            return AddressableSettings.IncludeTestGroups;
        }

        public override void OnGUI()
        {
            if (AddressableSettings.IncludeTestGroups)
            {
                EditorGUILayout.HelpBox("Include test groups options is enabled: this group will be included in build.", MessageType.Info);
            }
            else
            {
                EditorGUILayout.HelpBox("Include test groups options is disabled: this group will be excluded from build.\nGo to ProjectSettings/UGF/Addressable to change that option.", MessageType.Warning);
            }
        }
    }
}
