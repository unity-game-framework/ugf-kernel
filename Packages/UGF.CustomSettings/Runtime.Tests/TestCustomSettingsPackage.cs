using JetBrains.Annotations;

namespace UGF.CustomSettings.Runtime.Tests
{
    public static class TestCustomSettingsPackage
    {
        public static bool TestBoolValue { get { return m_boolValueTest; } set { m_boolValueTest.Value = value; } }

        private static CustomSettingsPackage<TestCustomSettingsPackageData> m_settings = new CustomSettingsPackage<TestCustomSettingsPackageData>("com.test.package");
        private static CustomSettingsProperty<TestCustomSettingsPackageData, bool> m_boolValueTest = new CustomSettingsProperty<TestCustomSettingsPackageData, bool>(m_settings, data => data.BoolValue, (data, value) => data.BoolValue = value);

#if UNITY_EDITOR
        [UnityEditor.SettingsProvider, UsedImplicitly]
        private static UnityEditor.SettingsProvider GetSettingsProvider()
        {
            return new Editor.CustomSettingsProvider<TestCustomSettingsPackageData>("Project/Test/Settings", m_settings, UnityEditor.SettingsScope.Project);
        }
#endif
    }
}
