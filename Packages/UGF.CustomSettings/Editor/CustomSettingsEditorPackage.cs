using System;
using UnityEngine;

namespace UGF.CustomSettings.Editor
{
    public class CustomSettingsEditorPackage<TData> : CustomSettingsEditorAsset<TData> where TData : ScriptableObject, new()
    {
        public CustomSettingsEditorPackage(string packageName, string settingsName = "settings", string folderPath = "Assets/Settings/Editor") : base($"{folderPath}/{packageName}.{settingsName}.asset")
        {
            if (string.IsNullOrEmpty(packageName)) throw new ArgumentException("The package name cannot be null or empty.", nameof(packageName));
            if (string.IsNullOrEmpty(settingsName)) throw new ArgumentException("The package name cannot be null or empty.", nameof(settingsName));
            if (string.IsNullOrEmpty(folderPath)) throw new ArgumentException("The folder path cannot be null or empty.", nameof(folderPath));
        }
    }
}
