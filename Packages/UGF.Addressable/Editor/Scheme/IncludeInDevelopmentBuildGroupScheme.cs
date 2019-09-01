using UnityEditor;

namespace UGF.Addressable.Editor.Scheme
{
    public class IncludeInDevelopmentBuildGroupScheme : IncludeGroupSchemeBase
    {
        public override bool IsIncluded()
        {
            return EditorUserBuildSettings.development;
        }

        public override void OnGUI()
        {
            if (EditorUserBuildSettings.development)
            {
                EditorGUILayout.HelpBox("Development mode is enabled: this group will be included in build.", MessageType.Info);
            }
            else
            {
                EditorGUILayout.HelpBox("Development mode is disabled: this group will be excluded from build.", MessageType.Warning);
            }
        }
    }
}
