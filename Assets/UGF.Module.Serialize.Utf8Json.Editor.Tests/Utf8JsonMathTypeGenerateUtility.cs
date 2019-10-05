using System;
using System.Collections.Generic;
using System.IO;
using UGF.Code.Generate.Editor.Container.External;
using UGF.Utf8Json.Editor.ExternalType;
using Unity.Mathematics;
using UnityEditor;

namespace UGF.Module.Serialize.Utf8Json.Editor.Tests
{
    public static class Utf8JsonMathTypeGenerateUtility
    {
        public static void GenerateFiles(List<Utf8JsonMathTypeGenerateInfo> infos, string folderPath)
        {
            if (infos == null) throw new ArgumentNullException(nameof(infos));
            if (string.IsNullOrEmpty(folderPath)) throw new ArgumentNullException(nameof(folderPath));

            Directory.CreateDirectory(folderPath);

            for (int i = 0; i < infos.Count; i++)
            {
                Utf8JsonMathTypeGenerateInfo info = infos[i];
                Utf8JsonExternalTypeAssetInfo assetInfo = CreateAssetInfo(info);
                string path = $"{folderPath}/{info.Type.Name}.{Utf8JsonExternalTypeEditorUtility.ExternalTypeAssetExtensionName}";
                string content = EditorJsonUtility.ToJson(assetInfo, true);

                File.WriteAllText(path, content);
            }
        }

        public static List<Utf8JsonMathTypeGenerateInfo> GetDefaultInfos()
        {
            return new List<Utf8JsonMathTypeGenerateInfo>
            {
                new Utf8JsonMathTypeGenerateInfo(typeof(bool2), 2),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool2x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool2x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool2x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool3), 3),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool3x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool3x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool3x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool4), 4),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool4x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool4x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(bool4x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double2), 2),
                new Utf8JsonMathTypeGenerateInfo(typeof(double2x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double2x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double2x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double3), 3),
                new Utf8JsonMathTypeGenerateInfo(typeof(double3x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double3x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double3x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double4), 4),
                new Utf8JsonMathTypeGenerateInfo(typeof(double4x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double4x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(double4x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float2), 2),
                new Utf8JsonMathTypeGenerateInfo(typeof(float2x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float2x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float2x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float3), 3),
                new Utf8JsonMathTypeGenerateInfo(typeof(float3x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float3x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float3x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float4), 4),
                new Utf8JsonMathTypeGenerateInfo(typeof(float4x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float4x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(float4x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(half2), 2),
                new Utf8JsonMathTypeGenerateInfo(typeof(half3), 3),
                new Utf8JsonMathTypeGenerateInfo(typeof(half4), 4),
                new Utf8JsonMathTypeGenerateInfo(typeof(int2), 2),
                new Utf8JsonMathTypeGenerateInfo(typeof(int2x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int2x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int2x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int3), 3),
                new Utf8JsonMathTypeGenerateInfo(typeof(int3x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int3x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int3x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int4), 4),
                new Utf8JsonMathTypeGenerateInfo(typeof(int4x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int4x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(int4x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint2), 2),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint2x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint2x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint2x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint3), 3),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint3x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint3x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint3x4), 4, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint4), 4),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint4x2), 2, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint4x3), 3, false),
                new Utf8JsonMathTypeGenerateInfo(typeof(uint4x4), 4, false),
            };
        }

        private static Utf8JsonExternalTypeAssetInfo CreateAssetInfo(Utf8JsonMathTypeGenerateInfo info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            var assetInfo = new Utf8JsonExternalTypeAssetInfo { TypeName = info.Type.AssemblyQualifiedName };

            for (int i = 0; i < info.Count; i++)
            {
                CodeGenerateContainerExternalMemberInfo member = CreateMember(i, info.IsVector);

                assetInfo.Members.Add(member);
            }

            return assetInfo;
        }

        private static CodeGenerateContainerExternalMemberInfo CreateMember(int index, bool isVector)
        {
            return new CodeGenerateContainerExternalMemberInfo
            {
                Name = GetName(index, isVector),
                Active = true
            };
        }

        private static string GetName(int index, bool isVector)
        {
            switch (index)
            {
                case 0: return isVector ? "x" : "c0";
                case 1: return isVector ? "y" : "c1";
                case 2: return isVector ? "z" : "c2";
                case 3: return isVector ? "w" : "c3";
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
