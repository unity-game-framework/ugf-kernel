using UnityEditor;
using UnityEngine;

namespace UGF.Addressable.Editor.Scheme
{
    public class IncludeByPlatformGroupScheme : IncludeGroupSchemeBase
    {
        [SerializeField] private BuildTarget m_platform = BuildTarget.NoTarget;

        public BuildTarget Platform { get { return m_platform; } set { m_platform = value; } }

        public override bool IsIncluded()
        {
            return EditorUserBuildSettings.activeBuildTarget == m_platform;
        }

        public override void OnGUI()
        {
            base.OnGUI();

            BuildTarget activeBuildTarget = EditorUserBuildSettings.activeBuildTarget;

            if (m_platform == activeBuildTarget)
            {
                EditorGUILayout.HelpBox("Current platform is matched: this group will be included in build.", MessageType.Info);
            }
            else
            {
                EditorGUILayout.HelpBox($"Current platform is not matched: this group will be excluded from build. (Selected:'{activeBuildTarget}')", MessageType.Warning);
            }
        }
    }
}
