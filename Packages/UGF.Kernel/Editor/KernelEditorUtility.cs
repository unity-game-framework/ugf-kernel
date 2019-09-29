using System;
using System.IO;
using System.Text;
using UnityEditor;
using Object = UnityEngine.Object;

namespace UGF.Kernel.Editor
{
    public static class KernelEditorUtility
    {
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
