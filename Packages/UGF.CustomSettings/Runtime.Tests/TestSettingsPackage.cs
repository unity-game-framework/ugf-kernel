using JetBrains.Annotations;

namespace UGF.CustomSettings.Runtime.Tests
{
    public static class TestSettingsPackage
    {
        public static bool BoolValue { get { return m_boolValue; } set { m_boolValue.Value = value; } }

        private static readonly CustomSettingsPackage<TestSettingsPackageData> m_settings = new CustomSettingsPackage<TestSettingsPackageData>("com.test.package");

        private static readonly CustomSettingsProperty<TestSettingsPackageData, bool> m_boolValue = new CustomSettingsProperty<TestSettingsPackageData, bool>(m_settings)
        {
            Getter = data => data.BoolValue,
            Setter = (data, value) => data.BoolValue = value
        };

#if UNITY_EDITOR
        [UnityEditor.SettingsProvider, UsedImplicitly]
        private static UnityEditor.SettingsProvider GetSettingsProvider()
        {
            return new Editor.CustomSettingsProvider<TestSettingsPackageData>("Project/Test/Runtime Package", m_settings, UnityEditor.SettingsScope.Project);
        }
#endif
    }
}
