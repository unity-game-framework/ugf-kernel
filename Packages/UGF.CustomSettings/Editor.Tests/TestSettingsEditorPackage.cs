using UGF.CustomSettings.Runtime;
using UnityEditor;
using UnityEngine;

namespace UGF.CustomSettings.Editor.Tests
{
    public class TestSettingsEditorPackage
    {
        public static Material Material { get { return m_material; } set { m_material.Value = value; } }
        public static LayerMask LayerMask { get { return m_layerMask; } set { m_layerMask.Value = value; } }

        private static readonly CustomSettingsEditorPackage<TestSettingsEditorPackageData> m_settings = new CustomSettingsEditorPackage<TestSettingsEditorPackageData>("com.test.editor.package");

        private static readonly CustomSettingsProperty<TestSettingsEditorPackageData, Material> m_material = new CustomSettingsProperty<TestSettingsEditorPackageData, Material>(m_settings)
        {
            Getter = data => data.Material,
            Setter = (data, value) => data.Material = value
        };

        private static readonly CustomSettingsProperty<TestSettingsEditorPackageData, LayerMask> m_layerMask = new CustomSettingsProperty<TestSettingsEditorPackageData, LayerMask>(m_settings)
        {
            Getter = data => data.Mask,
            Setter = (data, value) => data.Mask = value
        };

        [SettingsProvider]
        private static SettingsProvider GetSettingsProvider()
        {
            return new CustomSettingsProvider<TestSettingsEditorPackageData>("Project/Test/Editor Package", m_settings, SettingsScope.Project);
        }
    }
}
