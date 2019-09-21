using System.IO;
using UGF.Kernel.Runtime;
using UGF.Module.Runtime;
using UnityEditor;
using UnityEngine;

namespace UGF.Kernel.Editor
{
    [CustomPropertyDrawer(typeof(KernelModuleInfo), true)]
    internal class KernelModuleInfoDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty propertyBuilderId = property.FindPropertyRelative("m_builderId");
            SerializedProperty propertyArguments = property.FindPropertyRelative("m_arguments");

            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float heightHeader = EditorGUIUtility.singleLineHeight;
            float heightBuilderId = EditorGUI.GetPropertyHeight(propertyBuilderId);
            float heightArguments = EditorGUI.GetPropertyHeight(propertyArguments);

            var rectHeader = new Rect(position.x, position.y, 0F, heightHeader);
            var rectBuilderId = new Rect(position.x, rectHeader.yMax + spacing, position.width, heightBuilderId);
            var rectArguments = new Rect(position.x, rectBuilderId.yMax + spacing, position.width, heightArguments);

            string assetName = Path.GetFileNameWithoutExtension(propertyBuilderId.stringValue);
            string headerLabel = !string.IsNullOrEmpty(assetName) ? assetName : property.displayName;

            property.isExpanded = EditorGUI.Foldout(rectHeader, property.isExpanded, headerLabel);

            if (property.isExpanded)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    KernelEditorGUIUtility.ResourcesObjectField(rectBuilderId, "Builder", propertyBuilderId, typeof(ModuleBuilderAsset));

                    EditorGUI.PropertyField(rectArguments, propertyArguments, true);
                }
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
