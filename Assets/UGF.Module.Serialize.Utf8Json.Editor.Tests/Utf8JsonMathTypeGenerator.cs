using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UGF.Module.Serialize.Utf8Json.Editor.Tests
{
    public class Utf8JsonMathTypeGenerator : ScriptableObject
    {
        [SerializeField] private Object m_folder;

        public Object Folder { get { return m_folder; } set { m_folder = value; } }

        [ContextMenu("Generate", false, 1000)]
        public void Generate()
        {
            Generate(m_folder);
        }

        public void Generate(Object folder)
        {
            if (folder == null) throw new ArgumentNullException(nameof(folder));

            string path = AssetDatabase.GetAssetPath(folder);

            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));

            List<Utf8JsonMathTypeGenerateInfo> infos = Utf8JsonMathTypeGenerateUtility.GetDefaultInfos();

            Utf8JsonMathTypeGenerateUtility.GenerateFiles(infos, path);

            AssetDatabase.Refresh();
        }
    }
}
