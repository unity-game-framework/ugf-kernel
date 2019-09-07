using System;
using UnityEngine;

namespace UGF.CustomSettings.Editor.Tests
{
    [Serializable]
    public class TestSettingsEditorFileData
    {
        [SerializeField] private Material m_material;
        [SerializeField] private LayerMask m_mask;
        [SerializeField] private bool m_state;

        public Material Material { get { return m_material; } set { m_material = value; } }
        public LayerMask Mask { get { return m_mask; } set { m_mask = value; } }
        public bool State { get { return m_state; } set { m_state = value; } }
    }
}
