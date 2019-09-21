using UGF.Module.Runtime;
using UnityEditor;

namespace UGF.Kernel.Editor
{
    [CustomEditor(typeof(ModuleBuilderAsset), true)]
    internal class KernelModuleBuilderAssetEditor : UnityEditor.Editor
    {
        private ModuleBuilderAsset m_asset;

        private void OnEnable()
        {
            m_asset = (ModuleBuilderAsset)serializedObject.targetObject;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.HelpBox($"Register Type: '{m_asset.RegisterType}'.", MessageType.Info);
        }
    }
}
