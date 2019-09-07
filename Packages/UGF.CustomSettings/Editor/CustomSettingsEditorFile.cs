using System;
using System.IO;
using UGF.CustomSettings.Runtime;
using UnityEditor;
using UnityEngine;

namespace UGF.CustomSettings.Editor
{
    public class CustomSettingsEditorFile<TData> : CustomSettings<TData> where TData : class, new()
    {
        public string FilePath { get; }

        public CustomSettingsEditorFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentException("The file path cannot be null or empty.", nameof(filePath));

            FilePath = filePath;
        }

        protected override void Save(TData instance)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));

            string directory = Path.GetDirectoryName(FilePath);

            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string text = EditorJsonUtility.ToJson(instance, true);

            File.WriteAllText(FilePath, text);
        }

        protected override TData Load()
        {
            string text = "{}";
            var target = new TData();

            if (File.Exists(FilePath))
            {
                text = File.ReadAllText(FilePath);
            }
            else
            {
                Debug.LogWarning($"{typeof(TData).Name}: no settings data found at file path: '{FilePath}'.");
            }

            EditorJsonUtility.FromJsonOverwrite(text, target);

            return target;
        }
    }
}
