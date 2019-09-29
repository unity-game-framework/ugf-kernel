using System;
using System.Collections.Generic;
using System.Text;
using UGF.Application.Runtime;
using UGF.Kernel.Runtime;
using UnityEditor;

namespace UGF.Kernel.Editor
{
    [CustomEditor(typeof(KernelLauncher), true)]
    internal class KernelLauncherEditor : UnityEditor.Editor
    {
        private readonly string[] m_exclude = { "m_Script", "m_configId" };
        private readonly StringBuilder m_builder = new StringBuilder(100);
        private KernelLauncher m_launcher;
        private SerializedProperty m_propertyScript;
        private SerializedProperty m_propertyConfigId;

        private void OnEnable()
        {
            m_launcher = (KernelLauncher)serializedObject.targetObject;
            m_propertyScript = serializedObject.FindProperty("m_Script");
            m_propertyConfigId = serializedObject.FindProperty("m_configId");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.UpdateIfRequiredOrScript();

            using (new EditorGUI.DisabledScope(true))
            {
                EditorGUILayout.PropertyField(m_propertyScript);
            }

            KernelEditorGUIUtility.ResourcesObjectField("Config", m_propertyConfigId, typeof(KernelConfigAsset));

            DrawPropertiesExcluding(serializedObject, m_exclude);

            serializedObject.ApplyModifiedProperties();
        }

        private void DrawInfo()
        {
            m_builder.Clear();

            if (m_launcher.HasApplication)
            {
                IApplication application = m_launcher.Application;

                m_builder.Append($"Modules: {application.Modules.Count}");

                foreach (KeyValuePair<Type, IApplicationModule> pair in application.Modules)
                {
                    m_builder.AppendLine();
                    m_builder.Append(' ', 4);
                    m_builder.Append(pair.Value.GetType().Name);
                }
            }
            else
            {
                m_builder.Append("No application.");
            }

            EditorGUILayout.HelpBox(m_builder.ToString(), MessageType.Info);
        }
    }
}
