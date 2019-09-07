using System.IO;
using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsFile<TData> : CustomSettingsPlayMode<TData> where TData : class, new()
    {
        public string FilePath { get; }

        public CustomSettingsFile(string filePath)
        {
            FilePath = filePath;
        }

        protected override void Save(TData instance)
        {
            string directory = Path.GetDirectoryName(FilePath);

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string data = JsonUtility.ToJson(instance, true);

            File.WriteAllText(FilePath, data);
        }

        protected override TData Load()
        {
            string data = "{}";

            if (File.Exists(FilePath))
            {
                data = File.ReadAllText(FilePath);
            }
            else
            {
                Debug.LogWarning($"{typeof(TData).Name}: no settings data found at file path: '{FilePath}'.");
            }

            return JsonUtility.FromJson<TData>(data);
        }
    }
}
