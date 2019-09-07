using UGF.CustomSettings.Runtime;

namespace UGF.CustomSettings.Editor.Tests
{
    public static class TestSettingsPrefs
    {
        private static readonly CustomSettingsPrefs<TestSettingsData2> m_settings = new CustomSettingsPrefs<TestSettingsData2>("test.settings");
    }
}
