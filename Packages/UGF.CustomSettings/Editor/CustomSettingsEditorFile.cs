using System.IO;
using UGF.CustomSettings.Runtime;
using UnityEditor;
using UnityEngine;

namespace UGF.CustomSettings.Editor
{
    public class CustomSettingsEditorFile<TData> : CustomSettings<TData> where TData : class, new()
    {
        public string Path { get; }

        public CustomSettingsEditorFile(string path)
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

            string data = EditorJsonUtility.ToJson(instance, true);

            File.WriteAllText(Path, data);
        }

        protected override TData Load()
        {
            string data = "{}";
            var target = new TData();

            if (File.Exists(Path))
            {
                data = File.ReadAllText(Path);
            }
            else
            {
                Debug.LogWarning($"{typeof(TData).Name}: no settings data found at file path: '{Path}'.");
            }

            EditorJsonUtility.FromJsonOverwrite(data, target);

            return target;
        }
    }
}
