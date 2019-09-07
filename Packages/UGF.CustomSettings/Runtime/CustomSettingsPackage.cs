using System.IO;
using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsPackage<TData> : CustomSettingsResources<TData> where TData : ScriptableObject, new()
    {
        public string FolderPath { get; set; } = "Assets/Settings/Resources";

        public CustomSettingsPackage(string packageName, string settingsName = "settings") : base($"{packageName}.{settingsName}")
        {
        }

        protected override TData Load()
        {
#if UNITY_EDITOR
            string assetPath = $"{FolderPath}/{ResourcesPath}.asset";

            if (!File.Exists(assetPath))
            {
                string directoryName = Path.GetDirectoryName(assetPath);

                if (!string.IsNullOrEmpty(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }

                var data = ScriptableObject.CreateInstance<TData>();

                UnityEditor.AssetDatabase.CreateAsset(data, assetPath);
                UnityEditor.AssetDatabase.ImportAsset(assetPath);
            }
#endif

            return base.Load();
        }
    }
}
