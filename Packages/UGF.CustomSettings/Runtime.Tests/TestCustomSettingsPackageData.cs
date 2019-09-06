using UnityEngine;

namespace UGF.CustomSettings.Runtime.Tests
{
    public class TestCustomSettingsPackageData : ScriptableObject
    {
        [SerializeField] private bool m_boolValue = true;

        public bool BoolValue { get { return m_boolValue; } set { m_boolValue = value; } }
    }
}
