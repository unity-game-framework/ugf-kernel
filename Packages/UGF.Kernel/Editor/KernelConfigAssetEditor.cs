using System.Collections.Generic;
using UGF.CustomSettings.Editor;
using UGF.Kernel.Runtime;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace UGF.Kernel.Editor
{
    [CustomEditor(typeof(KernelConfigAsset), true)]
    internal class KernelConfigAssetEditor : UnityEditor.Editor
    {
        private readonly Dictionary<SerializedProperty, UnityEditor.Editor> m_editors = new Dictionary<SerializedProperty, UnityEditor.Editor>();
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
            m_list.onAddCallback = OnAdd;
            m_list.onSelectCallback = OnSelect;
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

            if (m_editors.Count > 0)
            {
                DrawEditors();
            }
            else
            {
                EditorGUILayout.HelpBox("Select any module to display settings.", MessageType.Info);
            }
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

        private void OnAdd(ReorderableList list)
        {
            SerializedProperty propertyModules = list.serializedProperty;

            propertyModules.InsertArrayElementAtIndex(propertyModules.arraySize);

            SerializedProperty propertyElement = propertyModules.GetArrayElementAtIndex(propertyModules.arraySize - 1);
            SerializedProperty propertyBuilderId = propertyElement.FindPropertyRelative("m_builderId");
            SerializedProperty propertyArgumentValues = propertyElement.FindPropertyRelative("m_arguments.m_values");

            propertyBuilderId.stringValue = string.Empty;
            propertyArgumentValues.ClearArray();

            serializedObject.ApplyModifiedProperties();
        }

        private void OnSelect(ReorderableList list)
        {
            SerializedProperty propertyElement = list.serializedProperty.GetArrayElementAtIndex(list.index);

            ClearEditors();
            CreateEditors(propertyElement);
        }

        private void DrawEditors()
        {
            foreach (KeyValuePair<SerializedProperty, UnityEditor.Editor> pair in m_editors)
            {
                SerializedProperty serializedProperty = pair.Key;
                UnityEditor.Editor editor = pair.Value;

                serializedProperty.isExpanded = EditorGUILayout.InspectorTitlebar(serializedProperty.isExpanded, editor);

                if (serializedProperty.isExpanded)
                {
                    editor.OnInspectorGUI();
                }
            }
        }

        private void CreateEditors(SerializedProperty propertyElement)
        {
            SerializedProperty propertyBuilderId = propertyElement.FindPropertyRelative("m_builderId");
            SerializedProperty propertyArgumentValues = propertyElement.FindPropertyRelative("m_arguments.m_values");

            CreateEditor(propertyBuilderId);

            for (int i = 0; i < propertyArgumentValues.arraySize; i++)
            {
                SerializedProperty propertyValue = propertyArgumentValues.GetArrayElementAtIndex(i);

                CreateEditor(propertyValue);
            }
        }

        private void CreateEditor(SerializedProperty serializedProperty)
        {
            Object asset = Resources.Load(serializedProperty.stringValue);

            if (asset != null)
            {
                UnityEditor.Editor editor = UnityEditor.Editor.CreateEditor(asset);

                m_editors.Add(serializedProperty, editor);
            }
        }

        private void ClearEditors()
        {
            foreach (KeyValuePair<SerializedProperty, UnityEditor.Editor> pair in m_editors)
            {
                DestroyImmediate(pair.Value);
            }

            m_editors.Clear();
        }
    }
}
