using UGF.Module.Descriptions.Runtime;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace UGF.Module.Descriptions.Editor
{
    [CustomEditor(typeof(DescriptionModuleBuilderAsset), true)]
    internal class DescriptionModuleBuilderAssetEditor : UnityEditor.Editor
    {
        private readonly GUIContent[] m_labels = { new GUIContent("Register Name"), new GUIContent("Asset Name") };
        private SerializedProperty m_propertyScript;
        private ReorderableList m_list;

        private void OnEnable()
        {
            m_propertyScript = serializedObject.FindProperty("m_Script");

            SerializedProperty propertyAssetInfos = serializedObject.FindProperty("m_description.m_assetInfos");

            m_list = new ReorderableList(serializedObject, propertyAssetInfos);
            m_list.drawHeaderCallback = OnDrawHeader;
            m_list.drawElementCallback = OnDrawElement;
            m_list.elementHeightCallback = OnElementHeight;
            m_list.onAddCallback = OnAdd;
        }

        public override void OnInspectorGUI()
        {
            serializedObject.UpdateIfRequiredOrScript();

            using (new EditorGUI.DisabledScope(true))
            {
                EditorGUILayout.PropertyField(m_propertyScript);
            }

            m_list.DoLayoutList();

            serializedObject.ApplyModifiedProperties();
        }

        private void OnDrawHeader(Rect rect)
        {
            string label = $"Descriptions (Size: {m_list.count})";

            GUI.Label(rect, label, EditorStyles.boldLabel);
        }

        private void OnDrawElement(Rect rect, int index, bool isActive, bool isFocused)
        {
            SerializedProperty propertyElement = m_list.serializedProperty.GetArrayElementAtIndex(index);
            SerializedProperty propertyRegisterName = propertyElement.FindPropertyRelative("m_registerName");

            rect.y += EditorGUIUtility.standardVerticalSpacing;
            rect.height = EditorGUIUtility.singleLineHeight;

            EditorGUI.MultiPropertyField(rect, m_labels, propertyRegisterName);
        }

        private float OnElementHeight(int index)
        {
            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float height = EditorGUIUtility.singleLineHeight;

            return height + spacing * 2F;
        }

        private void OnAdd(ReorderableList list)
        {
            SerializedProperty propertyModules = list.serializedProperty;

            propertyModules.InsertArrayElementAtIndex(propertyModules.arraySize);

            SerializedProperty propertyElement = propertyModules.GetArrayElementAtIndex(propertyModules.arraySize - 1);
            SerializedProperty propertyRegisterName = propertyElement.FindPropertyRelative("m_registerName");
            SerializedProperty propertyAssetName = propertyElement.FindPropertyRelative("m_assetName");

            propertyRegisterName.stringValue = string.Empty;
            propertyAssetName.stringValue = string.Empty;

            serializedObject.ApplyModifiedProperties();
        }
    }
}
