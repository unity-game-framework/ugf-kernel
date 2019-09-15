using UGF.Description.Runtime;
using UGF.Module.Runtime;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace UGF.Kernel.Editor
{
    // [CustomEditor(typeof(KernelConfigAsset))]
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

            EditorGUILayout.PropertyField(m_propertyName);

            m_list.DoLayoutList();

            serializedObject.ApplyModifiedProperties();
        }

        private void OnDrawHeader(Rect rect)
        {
            string label = $"Modules (Size: {m_list.count})";

            GUI.Label(rect, label, EditorStyles.boldLabel);
        }

        private void OnDrawElement(Rect rect, int index, bool isActive, bool isFocused)
        {
            float height = EditorGUIUtility.singleLineHeight;
            float spacing = EditorGUIUtility.standardVerticalSpacing;

            var rectBuilder = new Rect(rect.x, rect.y + spacing, rect.width, height);
            var rectDescription = new Rect(rect.x, rectBuilder.y + height + spacing, rect.width, height);

            SerializedProperty propertyElement = m_list.serializedProperty.GetArrayElementAtIndex(index);
            SerializedProperty propertyBuilderId = propertyElement.FindPropertyRelative("m_builderId");
            SerializedProperty propertyDescriptionId = propertyElement.FindPropertyRelative("m_descriptionId");

            var builderAsset = Resources.Load<ModuleBuilderAsset>(propertyBuilderId.stringValue);
            var descriptionAsset = Resources.Load<DescriptionAsset>(propertyDescriptionId.stringValue);

            builderAsset = (ModuleBuilderAsset)EditorGUI.ObjectField(rectBuilder, "Builder", builderAsset, typeof(ModuleBuilderAsset), false);
            descriptionAsset = (DescriptionAsset)EditorGUI.ObjectField(rectDescription, "Description", descriptionAsset, typeof(DescriptionAsset), false);

            propertyBuilderId.stringValue = builderAsset != null ? builderAsset.name : string.Empty;
            propertyDescriptionId.stringValue = descriptionAsset != null ? descriptionAsset.name : string.Empty;
        }

        private float OnElementHeight(int index)
        {
            return EditorGUIUtility.singleLineHeight * 2F + EditorGUIUtility.standardVerticalSpacing * 4F;
        }
    }
}
