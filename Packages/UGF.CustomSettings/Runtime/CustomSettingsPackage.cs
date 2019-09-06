using System.IO;
using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsPackage<TData> : CustomSettingsResources<TData> where TData : ScriptableObject, new()
    {
        public CustomSettingsPackage(string packageName, string settingsName = "settings") : base($"{packageName}.{settingsName}")
        {
        }

        protected override TData Load()
        {
#if UNITY_EDITOR
            string assetPath = $"Assets/Settings/Resources/{Path}.asset";
            string directoryName = System.IO.Path.GetDirectoryName(assetPath);

            if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }

            if (!File.Exists(assetPath))
            {
                var data = ScriptableObject.CreateInstance<TData>();

                UnityEditor.AssetDatabase.CreateAsset(data, assetPath);
                UnityEditor.AssetDatabase.SaveAssets();
            }
#endif

            return base.Load();
        }
    }
}
