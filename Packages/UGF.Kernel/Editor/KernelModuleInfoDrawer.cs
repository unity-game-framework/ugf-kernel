using System;
using System.Collections.Generic;
using System.IO;
using UGF.CustomSettings.Editor;
using UGF.Description.Runtime;
using UGF.Kernel.Runtime;
using UGF.Module.Runtime;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UGF.Kernel.Editor
{
    [CustomPropertyDrawer(typeof(KernelModuleInfo), true)]
    internal class KernelModuleInfoDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty propertyActive = property.FindPropertyRelative("m_active");
            SerializedProperty propertyBuilderId = property.FindPropertyRelative("m_builderId");
            SerializedProperty propertyArguments = property.FindPropertyRelative("m_arguments");
            SerializedProperty propertyValues = property.FindPropertyRelative("m_arguments.m_values");

            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float heightHeader = EditorGUIUtility.singleLineHeight;
            float heightActive = EditorGUI.GetPropertyHeight(propertyActive);
            float heightBuilderId = EditorGUI.GetPropertyHeight(propertyBuilderId);
            float heightArguments = heightHeader * propertyValues.arraySize;

            var rectHeader = new Rect(position.x - 15F, position.y, 15F, heightHeader);
            var rectActive = new Rect(position.x, rectHeader.yMax + spacing, position.width, heightActive);
            var rectBuilderId = new Rect(position.x, rectActive.yMax + spacing, position.width, heightBuilderId);
            var rectArguments = new Rect(position.x, rectBuilderId.yMax + spacing, position.width, heightArguments);

            string assetName = Path.GetFileNameWithoutExtension(propertyBuilderId.stringValue);
            string headerLabel = !string.IsNullOrEmpty(assetName) ? assetName : property.displayName;
            List<Type> arguments = GetArguments(propertyBuilderId);

            using (new CustomSettingsGUIScope(false))
            {
                property.isExpanded = EditorGUI.Foldout(rectHeader, property.isExpanded, headerLabel);
            }

            if (property.isExpanded)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    EditorGUI.PropertyField(rectActive, propertyActive);

                    KernelEditorGUIUtility.ResourcesObjectField(rectBuilderId, "Builder", propertyBuilderId, typeof(ModuleBuilderAsset));

                    DrawArguments(rectArguments, propertyArguments, arguments);
                }
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty propertyActive = property.FindPropertyRelative("m_active");
            SerializedProperty propertyBuilderId = property.FindPropertyRelative("m_builderId");
            SerializedProperty propertyValues = property.FindPropertyRelative("m_arguments.m_values");

            int argumentsCount = propertyValues.arraySize;

            float height = 0F;
            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float heightHeader = EditorGUIUtility.singleLineHeight;
            float heightActive = EditorGUI.GetPropertyHeight(propertyActive);
            float heightBuilderId = EditorGUI.GetPropertyHeight(propertyBuilderId);
            float heightArguments = heightHeader * argumentsCount + spacing * argumentsCount;

            height += heightHeader;

            if (property.isExpanded)
            {
                height += heightActive + heightBuilderId + heightArguments + spacing;
            }

            return height;
        }

        private static void DrawArguments(Rect position, SerializedProperty property, IReadOnlyList<Type> arguments)
        {
            SerializedProperty propertyValues = property.FindPropertyRelative("m_values");

            SetupArguments(propertyValues, arguments.Count);

            float height = EditorGUIUtility.singleLineHeight;
            var rect = new Rect(position.x, position.y, position.width, height);

            for (int i = 0; i < propertyValues.arraySize; i++)
            {
                SerializedProperty propertyElement = propertyValues.GetArrayElementAtIndex(i);

                DrawElement(rect, propertyElement, i, typeof(DescriptionAsset));

                rect = NextElement(rect);
            }
        }

        private static void SetupArguments(SerializedProperty propertyValues, int count)
        {
            if (propertyValues.arraySize != count)
            {
                propertyValues.ClearArray();

                for (int i = 0; i < count; i++)
                {
                    propertyValues.InsertArrayElementAtIndex(propertyValues.arraySize);

                    SerializedProperty propertyElement = propertyValues.GetArrayElementAtIndex(propertyValues.arraySize - 1);

                    propertyElement.stringValue = string.Empty;
                }
            }
        }

        private static Rect NextElement(Rect position)
        {
            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float height = EditorGUIUtility.singleLineHeight;

            return new Rect(position.x, position.yMax + spacing, position.width, height);
        }

        private static void DrawElement(Rect position, SerializedProperty propertyElement, int index, Type type)
        {
            Object builderAsset = Resources.Load(propertyElement.stringValue, type);
            string label = builderAsset != null ? builderAsset.name : $"Argument {index}";

            KernelEditorGUIUtility.ResourcesObjectField(position, label, propertyElement, type);
        }

        private static List<Type> GetArguments(SerializedProperty propertyBuilderId)
        {
            var arguments = new List<Type>();
            string builderId = propertyBuilderId.stringValue;
            Object asset = Resources.Load(builderId);

            if (asset != null)
            {
                Type type = asset.GetType();
                Type baseType = type.BaseType;

                if (baseType != null)
                {
                    Type[] types = baseType.GetGenericArguments();

                    if (types.Length > 1)
                    {
                        for (int i = 1; i < types.Length; i++)
                        {
                            arguments.Add(types[i]);
                        }
                    }
                }
            }

            return arguments;
        }
    }
}
