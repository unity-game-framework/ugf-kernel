using System;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UGF.Kernel.Editor
{
    internal static class KernelEditorGUIUtility
    {
        public static void ResourcesObjectField(string label, SerializedProperty serializedProperty, Type assetType)
        {
            if (serializedProperty == null) throw new ArgumentNullException(nameof(serializedProperty));

            serializedProperty.stringValue = ResourcesObjectField(label, serializedProperty.stringValue, assetType);
        }

        public static string ResourcesObjectField(string label, string resourceId, Type assetType)
        {
            if (label == null) throw new ArgumentNullException(nameof(label));
            if (resourceId == null) throw new ArgumentNullException(nameof(resourceId));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            Object asset = Resources.Load(resourceId, assetType);

            asset = EditorGUILayout.ObjectField(label, asset, assetType, false);

            return asset != null ? GetResourcesFolderPath(asset) : string.Empty;
        }

        public static void ResourcesObjectField(Rect position, string label, SerializedProperty serializedProperty, Type assetType)
        {
            if (serializedProperty == null) throw new ArgumentNullException(nameof(serializedProperty));

            serializedProperty.stringValue = ResourcesObjectField(position, label, serializedProperty.stringValue, assetType);
        }

        public static string ResourcesObjectField(Rect position, string label, string resourceId, Type assetType)
        {
            if (label == null) throw new ArgumentNullException(nameof(label));
            if (resourceId == null) throw new ArgumentNullException(nameof(resourceId));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            Object asset = Resources.Load(resourceId, assetType);

            asset = EditorGUI.ObjectField(position, label, asset, assetType, false);

            return asset != null ? GetResourcesFolderPath(asset) : string.Empty;
        }

        public static string GetResourcesFolderPath(Object asset)
        {
            if (asset == null) throw new ArgumentNullException(nameof(asset));

            string assetPath = AssetDatabase.GetAssetPath(asset);

            return GetResourcesFolderPath(assetPath);
        }

        public static string GetResourcesFolderPath(string assetPath)
        {
            if (assetPath == null) throw new ArgumentNullException(nameof(assetPath));

            var builder = new StringBuilder(assetPath.Length);
            DirectoryInfo directory = Directory.GetParent(assetPath);
            string name = Path.GetFileNameWithoutExtension(assetPath);

            builder.Append(name);

            while (directory != null && directory.Name != "Resources")
            {
                builder.Insert(0, '/');
                builder.Insert(0, directory.Name);

                directory = directory.Parent;
            }

            return builder.ToString();
        }
    }
}
