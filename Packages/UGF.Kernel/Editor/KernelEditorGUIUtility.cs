using System;
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

            return asset != null ? KernelEditorUtility.GetResourcesFolderPath(asset) : string.Empty;
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

            return asset != null ? KernelEditorUtility.GetResourcesFolderPath(asset) : string.Empty;
        }
    }
}
