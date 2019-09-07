using System;
using UnityEngine;

namespace UGF.CustomSettings.Editor.Tests
{
    [Serializable]
    public class TestSettingsData2
    {
        [SerializeField] private bool m_state;

        public bool State { get { return m_state; } set { m_state = value; } }
    }
}
