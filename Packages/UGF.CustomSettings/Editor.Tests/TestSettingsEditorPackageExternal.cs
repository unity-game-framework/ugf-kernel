using JetBrains.Annotations;
using UGF.CustomSettings.Runtime;
using UnityEditor;
using UnityEngine;

namespace UGF.CustomSettings.Editor.Tests
{
    public static class TestSettingsEditorPackageExternal
    {
        public static Material Material { get { return m_material; } set { m_material.Value = value; } }
        public static LayerMask LayerMask { get { return m_layerMask; } set { m_layerMask.Value = value; } }
        public static bool State { get { return m_state; } set { m_state.Value = value; } }

        private static readonly CustomSettingsEditorPackage<TestSettingsEditorData> m_settings = new CustomSettingsEditorPackage<TestSettingsEditorData>("com.test.editor.package.external", true);

        private static readonly CustomSettingsProperty<TestSettingsEditorData, Material> m_material = new CustomSettingsProperty<TestSettingsEditorData, Material>(m_settings)
        {
            Getter = data => data.Material,
            Setter = (data, value) => data.Material = value
        };

        private static readonly CustomSettingsProperty<TestSettingsEditorData, LayerMask> m_layerMask = new CustomSettingsProperty<TestSettingsEditorData, LayerMask>(m_settings)
        {
            Getter = data => data.Mask,
            Setter = (data, value) => data.Mask = value
        };

        private static readonly CustomSettingsProperty<TestSettingsEditorData, bool> m_state = new CustomSettingsProperty<TestSettingsEditorData, bool>(m_settings)
        {
            Getter = data => data.State,
            Setter = (data, value) => data.State = value
        };

        [SettingsProvider, UsedImplicitly]
        private static SettingsProvider GetSettingsProvider()
        {
            return new CustomSettingsProvider<TestSettingsEditorData>("Project/Test/Editor External Package", m_settings, SettingsScope.Project);
        }
    }
}
