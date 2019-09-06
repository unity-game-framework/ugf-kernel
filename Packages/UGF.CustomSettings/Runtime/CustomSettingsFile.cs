using System.IO;
using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsFile<TData> : CustomSettingsPlayMode<TData> where TData : class, new()
    {
        public string Path { get; }

        public CustomSettingsFile(string path)
        {
            Path = path;
        }

        protected override void Save(TData instance)
        {
            string directory = System.IO.Path.GetDirectoryName(Path);

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string data = JsonUtility.ToJson(instance, true);

            File.WriteAllText(Path, data);
        }

        protected override TData Load()
        {
            string data = "{}";

            if (File.Exists(Path))
            {
                data = File.ReadAllText(Path);
            }
            else
            {
                Debug.LogWarning($"{typeof(TData).Name}: no settings data found at file path: '{Path}'.");
            }

            return JsonUtility.FromJson<TData>(data);
        }
    }
}
