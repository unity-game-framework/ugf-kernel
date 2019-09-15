using UGF.Description.Runtime;
using UGF.Kernel.Runtime;
using UnityEditor;
using UnityEngine;

namespace UGF.Kernel.Editor
{
    [CustomPropertyDrawer(typeof(KernelModuleInfoArguments))]
    internal class KernelModuleInfoArgumentsDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty propertyValues = property.FindPropertyRelative("m_values");
            SerializedProperty propertySize = property.FindPropertyRelative("m_values.Array.size");

            float height = EditorGUIUtility.singleLineHeight;

            var rect = new Rect(position.x, position.y, position.width, height);

            EditorGUI.PropertyField(rect, propertyValues, label);

            if (propertyValues.isExpanded)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    rect = NextElement(rect);

                    EditorGUI.PropertyField(rect, propertySize);

                    for (int i = 0; i < propertyValues.arraySize; i++)
                    {
                        SerializedProperty propertyElement = propertyValues.GetArrayElementAtIndex(i);

                        rect = NextElement(rect);

                        DrawElement(rect, propertyElement, i);
                    }
                }
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty propertyValues = property.FindPropertyRelative("m_values");

            return EditorGUI.GetPropertyHeight(propertyValues);
        }

        private static Rect NextElement(Rect position)
        {
            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float height = EditorGUIUtility.singleLineHeight;

            return new Rect(position.x, position.yMax + spacing, position.width, height);
        }

        private static void DrawElement(Rect position, SerializedProperty propertyElement, int index)
        {
            var builderAsset = Resources.Load<DescriptionAsset>(propertyElement.stringValue);
            string label = builderAsset != null ? builderAsset.name : $"Element {index}";

            builderAsset = (DescriptionAsset)EditorGUI.ObjectField(position, label, builderAsset, typeof(DescriptionAsset), false);

            propertyElement.stringValue = builderAsset != null ? builderAsset.name : string.Empty;
        }
    }
}
