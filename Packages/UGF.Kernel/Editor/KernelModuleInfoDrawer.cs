using UGF.Kernel.Runtime;
using UGF.Module.Runtime;
using UnityEditor;
using UnityEngine;

namespace UGF.Kernel.Editor
{
    [CustomPropertyDrawer(typeof(KernelModuleInfo))]
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

            var rectHeader = new Rect(position.x, position.y, position.width, heightHeader);
            var rectBuilderId = new Rect(position.x, rectHeader.yMax + spacing, position.width, heightBuilderId);
            var rectArguments = new Rect(position.x, rectBuilderId.yMax + spacing, position.width, heightArguments);

            EditorGUI.PropertyField(rectHeader, property);

            if (property.isExpanded)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    var builderAsset = Resources.Load<ModuleBuilderAsset>(propertyBuilderId.stringValue);

                    builderAsset = (ModuleBuilderAsset)EditorGUI.ObjectField(rectBuilderId, "Builder", builderAsset, typeof(ModuleBuilderAsset), false);

                    propertyBuilderId.stringValue = builderAsset != null ? builderAsset.name : string.Empty;

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
