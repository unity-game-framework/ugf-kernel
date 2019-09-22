using System;
using UGF.Module.Runtime;
using UnityEditor;

namespace UGF.Module.Editor
{
    [CustomEditor(typeof(ModuleBuilderAsset), true)]
    internal class ModuleBuilderAssetEditor : UnityEditor.Editor
    {
        private Type m_registerType;
        private Type[] m_arguments;

        private void OnEnable()
        {
            var asset = (ModuleBuilderAsset)serializedObject.targetObject;
            Type type = asset.GetType();

            m_registerType = asset.RegisterType;
            m_arguments = type.BaseType != null ? type.BaseType.GetGenericArguments() : Array.Empty<Type>();
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.HelpBox($"Register Type: '{m_registerType}'.", MessageType.Info);

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Required Arguments", EditorStyles.boldLabel);

            if (m_arguments.Length > 1)
            {
                for (int i = 1; i < m_arguments.Length; i++)
                {
                    int argumentIndex = i - 1;
                    Type argumentType = m_arguments[i];

                    EditorGUILayout.HelpBox($"Argument {argumentIndex}: '{argumentType}'.", MessageType.Info);
                }
            }
            else
            {
                EditorGUILayout.HelpBox("No information about required arguments.", MessageType.Info);
            }
        }
    }
}
