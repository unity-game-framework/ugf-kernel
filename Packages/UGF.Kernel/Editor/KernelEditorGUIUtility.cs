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
            serializedProperty.stringValue = ResourcesObjectField(label, serializedProperty.stringValue, assetType);
        }

        public static string ResourcesObjectField(string label, string resourceId, Type assetType)
        {
            Object asset = Resources.Load(resourceId, assetType);

            asset = EditorGUILayout.ObjectField(label, asset, assetType, false);

            return asset != null ? asset.name : string.Empty;
        }

        public static void ResourcesObjectField(Rect position, string label, SerializedProperty serializedProperty, Type assetType)
        {
            serializedProperty.stringValue = ResourcesObjectField(position, label, serializedProperty.stringValue, assetType);
        }

        public static string ResourcesObjectField(Rect position, string label, string resourceId, Type assetType)
        {
            Object asset = Resources.Load(resourceId, assetType);

            asset = EditorGUI.ObjectField(position, label, asset, assetType, false);

            return asset != null ? asset.name : string.Empty;
        }
    }
}
