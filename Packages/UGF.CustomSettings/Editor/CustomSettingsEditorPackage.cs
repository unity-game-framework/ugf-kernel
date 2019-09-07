using UnityEngine;

namespace UGF.CustomSettings.Editor
{
    public class CustomSettingsEditorPackage<TData> : CustomSettingsEditorAsset<TData> where TData : ScriptableObject, new()
    {
        public CustomSettingsEditorPackage(string packageName, string settingsName = "settings", string folderPath = "Assets/Settings/Editor") : base($"{folderPath}/{packageName}.{settingsName}.asset")
        {
        }
    }
}
