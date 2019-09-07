using UnityEngine;

namespace UGF.CustomSettings.Editor.Tests
{
    public class TestSettingsEditorPackageData : ScriptableObject
    {
        [SerializeField] private Material m_material;
        [SerializeField] private LayerMask m_mask;

        public Material Material { get { return m_material; } set { m_material = value; } }
        public LayerMask Mask { get { return m_mask; } set { m_mask = value; } }
    }
}
