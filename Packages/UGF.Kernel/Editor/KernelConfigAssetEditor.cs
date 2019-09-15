using UGF.CustomSettings.Editor;
using UGF.Kernel.Runtime;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace UGF.Kernel.Editor
{
    [CustomEditor(typeof(KernelConfigAsset))]
    internal class KernelConfigAssetEditor : UnityEditor.Editor
    {
        private SerializedProperty m_propertyName;
        private ReorderableList m_list;

        private void OnEnable()
        {
            m_propertyName = serializedObject.FindProperty("m_description.m_name");

            SerializedProperty propertyModules = serializedObject.FindProperty("m_description.m_modules");

            m_list = new ReorderableList(serializedObject, propertyModules);
            m_list.drawHeaderCallback = OnDrawHeader;
            m_list.drawElementCallback = OnDrawElement;
            m_list.elementHeightCallback = OnElementHeight;
        }

        public override void OnInspectorGUI()
        {
            serializedObject.UpdateIfRequiredOrScript();

            using (new CustomSettingsGUIScope())
            {
                EditorGUILayout.PropertyField(m_propertyName);

                m_list.DoLayoutList();
            }

            serializedObject.ApplyModifiedProperties();
        }

        private void OnDrawHeader(Rect rect)
        {
            string label = $"Modules (Size: {m_list.count})";

            GUI.Label(rect, label, EditorStyles.boldLabel);
        }

        private void OnDrawElement(Rect rect, int index, bool isActive, bool isFocused)
        {
            SerializedProperty propertyElement = m_list.serializedProperty.GetArrayElementAtIndex(index);
            float spacing = EditorGUIUtility.standardVerticalSpacing;

            rect.x += 15F;
            rect.width -= 15F;
            rect.y += spacing;

            using (new EditorGUI.IndentLevelScope(-EditorGUI.indentLevel))
            {
                EditorGUI.PropertyField(rect, propertyElement, true);
            }
        }

        private float OnElementHeight(int index)
        {
            SerializedProperty propertyElement = m_list.serializedProperty.GetArrayElementAtIndex(index);
            float spacing = EditorGUIUtility.standardVerticalSpacing;

            return EditorGUI.GetPropertyHeight(propertyElement, true) + spacing * 3F;
        }
    }
}
