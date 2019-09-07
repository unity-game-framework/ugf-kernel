using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

namespace UGF.CustomSettings.Editor.Tests
{
    public static class TestSettingsEditorFile
    {
        public static Material Material
        {
            get { return m_settings.Instance.Material; }
            set
            {
                m_settings.Instance.Material = value;
                m_settings.Save();
            }
        }

        public static LayerMask LayerMask
        {
            get { return m_settings.Instance.Mask; }
            set
            {
                m_settings.Instance.Mask = value;
                m_settings.Save();
            }
        }

        public static bool State
        {
            get { return m_settings.Instance.State; }
            set
            {
                m_settings.Instance.State = value;
                m_settings.Save();
            }
        }

        private static readonly CustomSettingsEditorFile<TestSettingsEditorFileData> m_settings = new CustomSettingsEditorFile<TestSettingsEditorFileData>("Assets/StreamingAssets/settings.json");

        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetSettingsProvider()
        {
            return new Provider("Project/Test/Editor File", SettingsScope.Project);
        }

        private class Provider : SettingsProvider
        {
            public Provider(string path, SettingsScope scopes) : base(path, scopes)
            {
            }

            public override void OnGUI(string searchContext)
            {
                base.OnGUI(searchContext);

                Material = (Material)EditorGUILayout.ObjectField("Material", Material, typeof(Material), false);

                State = EditorGUILayout.Toggle(State);
            }
        }
    }
}
