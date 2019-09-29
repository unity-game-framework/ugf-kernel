using UGF.Module.Descriptions.Runtime.Addressable;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace UGF.Module.Descriptions.Editor.Addressable
{
    [CustomEditor(typeof(DescriptionAddressableModuleDescriptionAsset))]
    internal class DescriptionAddressableModuleDescriptionAssetEditor : UnityEditor.Editor
    {
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
            SerializedProperty propertyAsset = propertyElement.FindPropertyRelative("m_asset");

            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float heightHeader = EditorGUIUtility.singleLineHeight;
            float heightRegisterName = EditorGUI.GetPropertyHeight(propertyRegisterName);
            float heightAsset = EditorGUI.GetPropertyHeight(propertyAsset);

            rect.x += 15F;
            rect.width -= 15F;
            rect.y += spacing;

            var rectHeader = new Rect(rect.x, rect.y, rect.width, heightHeader);
            var rectRegisterName = new Rect(rect.x, rectHeader.yMax + spacing, rect.width, heightRegisterName);
            var rectAsset = new Rect(rect.x, rectRegisterName.yMax + spacing, rect.width, heightAsset);

            string registerName = propertyRegisterName.stringValue;
            string headerLabel = !string.IsNullOrEmpty(registerName) ? registerName : propertyElement.displayName;

            propertyElement.isExpanded = EditorGUI.Foldout(rectHeader, propertyElement.isExpanded, headerLabel, true);

            if (propertyElement.isExpanded)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    EditorGUI.PropertyField(rectRegisterName, propertyRegisterName);

                    EditorGUI.PropertyField(rectAsset, propertyAsset, new GUIContent("Asset"));
                }
            }
        }

        private float OnElementHeight(int index)
        {
            SerializedProperty propertyElement = m_list.serializedProperty.GetArrayElementAtIndex(index);
            float spacing = EditorGUIUtility.standardVerticalSpacing;

            return EditorGUI.GetPropertyHeight(propertyElement, true) + spacing * 3F;
        }

        private void OnAdd(ReorderableList list)
        {
            SerializedProperty propertyModules = list.serializedProperty;

            propertyModules.InsertArrayElementAtIndex(propertyModules.arraySize);

            SerializedProperty propertyElement = propertyModules.GetArrayElementAtIndex(propertyModules.arraySize - 1);
            SerializedProperty propertyRegisterName = propertyElement.FindPropertyRelative("m_registerName");
            SerializedProperty propertyAssetGuid = propertyElement.FindPropertyRelative("m_asset.m_AssetGUID");
            SerializedProperty propertySubObjectName = propertyElement.FindPropertyRelative("m_asset.m_SubObjectName");

            propertyRegisterName.stringValue = string.Empty;
            propertyAssetGuid.stringValue = string.Empty;
            propertySubObjectName.stringValue = string.Empty;

            serializedObject.ApplyModifiedProperties();
        }
    }
}
