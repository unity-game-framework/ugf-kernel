using UGF.Description.Editor;
using UGF.Module.Runtime;
using UnityEditor;

namespace UGF.Module.Editor
{
    [CustomEditor(typeof(ModuleBuilderAsset), true)]
    internal class ModuleBuilderAssetEditor : DescriptionAssetEditor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var builder = (ModuleBuilderAsset)target;

            if (builder != null)
            {
                EditorGUILayout.Space();
                EditorGUILayout.HelpBox($"Register Type: '{builder.RegisterType}'.", MessageType.Info);
            }
        }

        protected override void DrawDescription()
        {
            SerializedProperty propertyDescription = serializedObject.FindProperty("m_description");

            if (propertyDescription != null)
            {
                base.DrawDescription();
            }
        }
    }
}
