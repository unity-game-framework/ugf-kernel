using System;
using System.Collections.Generic;
using System.Text;
using UGF.Application.Runtime;
using UGF.Kernel.Runtime;
using UnityEditor;

namespace UGF.Kernel.Editor
{
    [CustomEditor(typeof(KernelLauncher))]
    internal class KernelLauncherEditor : UnityEditor.Editor
    {
        private readonly StringBuilder m_builder = new StringBuilder(100);
        private KernelLauncher m_launcher;

        private void OnEnable()
        {
            m_launcher = (KernelLauncher)serializedObject.targetObject;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

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
