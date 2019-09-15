// THIS IS A GENERATED CODE. DO NOT EDIT.
// ReSharper disable all

namespace UGF.Module.Serialize.Utf8Json.Runtime.Resolvers
{
    using System;
    using Utf8Json;

    public class UGFModuleSerializeUtf8JsonRuntimeResolver : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new UGFModuleSerializeUtf8JsonRuntimeResolver();

        UGFModuleSerializeUtf8JsonRuntimeResolver()
        {

        }

        public global::Utf8Json.IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::Utf8Json.IJsonFormatter<T> formatter;

            static FormatterCache()
            {
                var f = UGFModuleSerializeUtf8JsonRuntimeResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class UGFModuleSerializeUtf8JsonRuntimeResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static UGFModuleSerializeUtf8JsonRuntimeResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(88)
            {
                {typeof(global::UnityEngine.Keyframe[]), 0 },
                {typeof(global::UnityEngine.GradientColorKey[]), 1 },
                {typeof(global::UnityEngine.GradientAlphaKey[]), 2 },
                {typeof(global::UnityEngine.WeightedMode), 3 },
                {typeof(global::UnityEngine.WrapMode), 4 },
                {typeof(global::UnityEngine.GradientMode), 5 },
                {typeof(global::UGF.Module.Serialize.Utf8Json.Runtime.SerializeUtf8JsonModuleDescription), 6 },
                {typeof(global::Unity.Mathematics.bool2), 7 },
                {typeof(global::Unity.Mathematics.bool2x2), 8 },
                {typeof(global::Unity.Mathematics.bool2x3), 9 },
                {typeof(global::Unity.Mathematics.bool2x4), 10 },
                {typeof(global::Unity.Mathematics.bool3), 11 },
                {typeof(global::Unity.Mathematics.bool3x2), 12 },
                {typeof(global::Unity.Mathematics.bool3x3), 13 },
                {typeof(global::Unity.Mathematics.bool3x4), 14 },
                {typeof(global::Unity.Mathematics.bool4), 15 },
                {typeof(global::Unity.Mathematics.bool4x2), 16 },
                {typeof(global::Unity.Mathematics.bool4x3), 17 },
                {typeof(global::Unity.Mathematics.bool4x4), 18 },
                {typeof(global::Unity.Mathematics.double2), 19 },
                {typeof(global::Unity.Mathematics.double2x2), 20 },
                {typeof(global::Unity.Mathematics.double2x3), 21 },
                {typeof(global::Unity.Mathematics.double2x4), 22 },
                {typeof(global::Unity.Mathematics.double3), 23 },
                {typeof(global::Unity.Mathematics.double3x2), 24 },
                {typeof(global::Unity.Mathematics.double3x3), 25 },
                {typeof(global::Unity.Mathematics.double3x4), 26 },
                {typeof(global::Unity.Mathematics.double4), 27 },
                {typeof(global::Unity.Mathematics.double4x2), 28 },
                {typeof(global::Unity.Mathematics.double4x3), 29 },
                {typeof(global::Unity.Mathematics.double4x4), 30 },
                {typeof(global::Unity.Mathematics.float2), 31 },
                {typeof(global::Unity.Mathematics.float2x2), 32 },
                {typeof(global::Unity.Mathematics.float2x3), 33 },
                {typeof(global::Unity.Mathematics.float2x4), 34 },
                {typeof(global::Unity.Mathematics.float3), 35 },
                {typeof(global::Unity.Mathematics.float3x2), 36 },
                {typeof(global::Unity.Mathematics.float3x3), 37 },
                {typeof(global::Unity.Mathematics.float3x4), 38 },
                {typeof(global::Unity.Mathematics.float4), 39 },
                {typeof(global::Unity.Mathematics.float4x2), 40 },
                {typeof(global::Unity.Mathematics.float4x3), 41 },
                {typeof(global::Unity.Mathematics.float4x4), 42 },
                {typeof(global::Unity.Mathematics.half), 43 },
                {typeof(global::Unity.Mathematics.half2), 44 },
                {typeof(global::Unity.Mathematics.half3), 45 },
                {typeof(global::Unity.Mathematics.half4), 46 },
                {typeof(global::Unity.Mathematics.int2), 47 },
                {typeof(global::Unity.Mathematics.int2x2), 48 },
                {typeof(global::Unity.Mathematics.int2x3), 49 },
                {typeof(global::Unity.Mathematics.int2x4), 50 },
                {typeof(global::Unity.Mathematics.int3), 51 },
                {typeof(global::Unity.Mathematics.int3x2), 52 },
                {typeof(global::Unity.Mathematics.int3x3), 53 },
                {typeof(global::Unity.Mathematics.int3x4), 54 },
                {typeof(global::Unity.Mathematics.int4), 55 },
                {typeof(global::Unity.Mathematics.int4x2), 56 },
                {typeof(global::Unity.Mathematics.int4x3), 57 },
                {typeof(global::Unity.Mathematics.int4x4), 58 },
                {typeof(global::Unity.Mathematics.quaternion), 59 },
                {typeof(global::Unity.Mathematics.Random), 60 },
                {typeof(global::Unity.Mathematics.RigidTransform), 61 },
                {typeof(global::Unity.Mathematics.uint2), 62 },
                {typeof(global::Unity.Mathematics.uint2x2), 63 },
                {typeof(global::Unity.Mathematics.uint2x3), 64 },
                {typeof(global::Unity.Mathematics.uint2x4), 65 },
                {typeof(global::Unity.Mathematics.uint3), 66 },
                {typeof(global::Unity.Mathematics.uint3x2), 67 },
                {typeof(global::Unity.Mathematics.uint3x3), 68 },
                {typeof(global::Unity.Mathematics.uint3x4), 69 },
                {typeof(global::Unity.Mathematics.uint4), 70 },
                {typeof(global::Unity.Mathematics.uint4x2), 71 },
                {typeof(global::Unity.Mathematics.uint4x3), 72 },
                {typeof(global::Unity.Mathematics.uint4x4), 73 },
                {typeof(global::UnityEngine.Keyframe), 74 },
                {typeof(global::UnityEngine.AnimationCurve), 75 },
                {typeof(global::UnityEngine.Vector3Int), 76 },
                {typeof(global::UnityEngine.BoundsInt), 77 },
                {typeof(global::UnityEngine.Color32), 78 },
                {typeof(global::UnityEngine.GradientColorKey), 79 },
                {typeof(global::UnityEngine.GradientAlphaKey), 80 },
                {typeof(global::UnityEngine.Gradient), 81 },
                {typeof(global::UnityEngine.LayerMask), 82 },
                {typeof(global::UnityEngine.Matrix4x4), 83 },
                {typeof(global::UnityEngine.RangeInt), 84 },
                {typeof(global::UnityEngine.RectInt), 85 },
                {typeof(global::UnityEngine.RectOffset), 86 },
                {typeof(global::UnityEngine.Vector2Int), 87 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new global::Utf8Json.Formatters.ArrayFormatter<global::UnityEngine.Keyframe>();
                case 1: return new global::Utf8Json.Formatters.ArrayFormatter<global::UnityEngine.GradientColorKey>();
                case 2: return new global::Utf8Json.Formatters.ArrayFormatter<global::UnityEngine.GradientAlphaKey>();
                case 3: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.WeightedModeFormatter();
                case 4: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.WrapModeFormatter();
                case 5: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.GradientModeFormatter();
                case 6: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UGF.Module.Serialize.Utf8Json.Runtime.SerializeUtf8JsonModuleDescriptionFormatter();
                case 7: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool2Formatter();
                case 8: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool2x2Formatter();
                case 9: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool2x3Formatter();
                case 10: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool2x4Formatter();
                case 11: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool3Formatter();
                case 12: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool3x2Formatter();
                case 13: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool3x3Formatter();
                case 14: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool3x4Formatter();
                case 15: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool4Formatter();
                case 16: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool4x2Formatter();
                case 17: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool4x3Formatter();
                case 18: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.bool4x4Formatter();
                case 19: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double2Formatter();
                case 20: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double2x2Formatter();
                case 21: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double2x3Formatter();
                case 22: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double2x4Formatter();
                case 23: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double3Formatter();
                case 24: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double3x2Formatter();
                case 25: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double3x3Formatter();
                case 26: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double3x4Formatter();
                case 27: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double4Formatter();
                case 28: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double4x2Formatter();
                case 29: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double4x3Formatter();
                case 30: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.double4x4Formatter();
                case 31: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float2Formatter();
                case 32: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float2x2Formatter();
                case 33: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float2x3Formatter();
                case 34: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float2x4Formatter();
                case 35: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float3Formatter();
                case 36: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float3x2Formatter();
                case 37: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float3x3Formatter();
                case 38: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float3x4Formatter();
                case 39: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float4Formatter();
                case 40: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float4x2Formatter();
                case 41: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float4x3Formatter();
                case 42: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.float4x4Formatter();
                case 43: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.halfFormatter();
                case 44: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.half2Formatter();
                case 45: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.half3Formatter();
                case 46: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.half4Formatter();
                case 47: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int2Formatter();
                case 48: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int2x2Formatter();
                case 49: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int2x3Formatter();
                case 50: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int2x4Formatter();
                case 51: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int3Formatter();
                case 52: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int3x2Formatter();
                case 53: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int3x3Formatter();
                case 54: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int3x4Formatter();
                case 55: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int4Formatter();
                case 56: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int4x2Formatter();
                case 57: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int4x3Formatter();
                case 58: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.int4x4Formatter();
                case 59: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.quaternionFormatter();
                case 60: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.RandomFormatter();
                case 61: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.RigidTransformFormatter();
                case 62: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint2Formatter();
                case 63: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint2x2Formatter();
                case 64: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint2x3Formatter();
                case 65: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint2x4Formatter();
                case 66: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint3Formatter();
                case 67: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint3x2Formatter();
                case 68: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint3x3Formatter();
                case 69: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint3x4Formatter();
                case 70: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint4Formatter();
                case 71: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint4x2Formatter();
                case 72: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint4x3Formatter();
                case 73: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics.uint4x4Formatter();
                case 74: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.KeyframeFormatter();
                case 75: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.AnimationCurveFormatter();
                case 76: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.Vector3IntFormatter();
                case 77: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.BoundsIntFormatter();
                case 78: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.Color32Formatter();
                case 79: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.GradientColorKeyFormatter();
                case 80: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.GradientAlphaKeyFormatter();
                case 81: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.GradientFormatter();
                case 82: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.LayerMaskFormatter();
                case 83: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.Matrix4x4Formatter();
                case 84: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.RangeIntFormatter();
                case 85: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.RectIntFormatter();
                case 86: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.RectOffsetFormatter();
                case 87: return new UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine.Vector2IntFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine
{
    using System;
    using Utf8Json;

    public sealed class WeightedModeFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.WeightedMode>
    {
        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.WeightedMode value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            writer.WriteInt32((Int32)value);
        }
        
        public global::UnityEngine.WeightedMode Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            return (global::UnityEngine.WeightedMode)reader.ReadInt32();
        }
    }

    public sealed class WrapModeFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.WrapMode>
    {
        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.WrapMode value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            writer.WriteInt32((Int32)value);
        }
        
        public global::UnityEngine.WrapMode Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            return (global::UnityEngine.WrapMode)reader.ReadInt32();
        }
    }

    public sealed class GradientModeFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.GradientMode>
    {
        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.GradientMode value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            writer.WriteInt32((Int32)value);
        }
        
        public global::UnityEngine.GradientMode Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            return (global::UnityEngine.GradientMode)reader.ReadInt32();
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UGF.Module.Serialize.Utf8Json.Runtime
{
    using System;
    using Utf8Json;


    public sealed class SerializeUtf8JsonModuleDescriptionFormatter : global::Utf8Json.IJsonFormatter<global::UGF.Module.Serialize.Utf8Json.Runtime.SerializeUtf8JsonModuleDescription>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SerializeUtf8JsonModuleDescriptionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("bytesSerializerName"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("textCompactSerializerName"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("textReadableSerializerName"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("bytesSerializerName"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("textCompactSerializerName"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("textReadableSerializerName"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UGF.Module.Serialize.Utf8Json.Runtime.SerializeUtf8JsonModuleDescription value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.BytesSerializerName);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.TextCompactSerializerName);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.TextReadableSerializerName);
            
            writer.WriteEndObject();
        }

        public global::UGF.Module.Serialize.Utf8Json.Runtime.SerializeUtf8JsonModuleDescription Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __BytesSerializerName__ = default(string);
            var __BytesSerializerName__b__ = false;
            var __TextCompactSerializerName__ = default(string);
            var __TextCompactSerializerName__b__ = false;
            var __TextReadableSerializerName__ = default(string);
            var __TextReadableSerializerName__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __BytesSerializerName__ = reader.ReadString();
                        __BytesSerializerName__b__ = true;
                        break;
                    case 1:
                        __TextCompactSerializerName__ = reader.ReadString();
                        __TextCompactSerializerName__b__ = true;
                        break;
                    case 2:
                        __TextReadableSerializerName__ = reader.ReadString();
                        __TextReadableSerializerName__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UGF.Module.Serialize.Utf8Json.Runtime.SerializeUtf8JsonModuleDescription();
            if(__BytesSerializerName__b__) ____result.BytesSerializerName = __BytesSerializerName__;
            if(__TextCompactSerializerName__b__) ____result.TextCompactSerializerName = __TextCompactSerializerName__;
            if(__TextReadableSerializerName__b__) ____result.TextReadableSerializerName = __TextReadableSerializerName__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace UGF.Module.Serialize.Utf8Json.Runtime.Formatters.Unity.Mathematics
{
    using System;
    using Utf8Json;


    public sealed class bool2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteBoolean(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteBoolean(value.y);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(bool);
            var __x__b__ = false;
            var __y__ = default(bool);
            var __y__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadBoolean();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadBoolean();
                        __y__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool2();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;

            return ____result;
        }
    }


    public sealed class bool2x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool2x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool2x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool2x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool2x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool2);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool2x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class bool2x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool2x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool2x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool2x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool2x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.bool2);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool2x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class bool2x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool2x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool2x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool2x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool2x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.bool2);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.bool2);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool2x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class bool3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteBoolean(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteBoolean(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteBoolean(value.z);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(bool);
            var __x__b__ = false;
            var __y__ = default(bool);
            var __y__b__ = false;
            var __z__ = default(bool);
            var __z__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadBoolean();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadBoolean();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadBoolean();
                        __z__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool3();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;

            return ____result;
        }
    }


    public sealed class bool3x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool3x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool3x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool3x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool3x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool3);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool3x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class bool3x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool3x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool3x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool3x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool3x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.bool3);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool3x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class bool3x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool3x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool3x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool3x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool3x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.bool3);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.bool3);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool3x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class bool4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteBoolean(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteBoolean(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteBoolean(value.z);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteBoolean(value.w);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(bool);
            var __x__b__ = false;
            var __y__ = default(bool);
            var __y__b__ = false;
            var __z__ = default(bool);
            var __z__b__ = false;
            var __w__ = default(bool);
            var __w__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadBoolean();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadBoolean();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadBoolean();
                        __z__b__ = true;
                        break;
                    case 3:
                        __w__ = reader.ReadBoolean();
                        __w__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool4();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;
            if(__w__b__) ____result.w = __w__;

            return ____result;
        }
    }


    public sealed class bool4x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool4x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool4x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool4x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool4x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool4);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool4x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class bool4x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool4x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool4x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool4x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool4x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.bool4);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool4x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class bool4x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.bool4x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public bool4x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.bool4x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.bool4x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.bool4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.bool4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.bool4);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.bool4);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.bool4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.bool4x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class double2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteDouble(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteDouble(value.y);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(double);
            var __x__b__ = false;
            var __y__ = default(double);
            var __y__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadDouble();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadDouble();
                        __y__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double2();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;

            return ____result;
        }
    }


    public sealed class double2x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double2x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double2x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double2x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double2x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double2);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double2x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class double2x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double2x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double2x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double2x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double2x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.double2);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double2x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class double2x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double2x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double2x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double2x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double2x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.double2);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.double2);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double2x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class double3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteDouble(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteDouble(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteDouble(value.z);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(double);
            var __x__b__ = false;
            var __y__ = default(double);
            var __y__b__ = false;
            var __z__ = default(double);
            var __z__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadDouble();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadDouble();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadDouble();
                        __z__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double3();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;

            return ____result;
        }
    }


    public sealed class double3x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double3x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double3x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double3x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double3x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double3);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double3x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class double3x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double3x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double3x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double3x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double3x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.double3);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double3x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class double3x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double3x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double3x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double3x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double3x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.double3);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.double3);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double3x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class double4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteDouble(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteDouble(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteDouble(value.z);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteDouble(value.w);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(double);
            var __x__b__ = false;
            var __y__ = default(double);
            var __y__b__ = false;
            var __z__ = default(double);
            var __z__b__ = false;
            var __w__ = default(double);
            var __w__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadDouble();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadDouble();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadDouble();
                        __z__b__ = true;
                        break;
                    case 3:
                        __w__ = reader.ReadDouble();
                        __w__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double4();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;
            if(__w__b__) ____result.w = __w__;

            return ____result;
        }
    }


    public sealed class double4x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double4x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double4x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double4x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double4x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double4);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double4x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class double4x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double4x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double4x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double4x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double4x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.double4);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double4x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class double4x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.double4x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public double4x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.double4x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.double4x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.double4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.double4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.double4);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.double4);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.double4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.double4x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class float2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.y);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(float);
            var __x__b__ = false;
            var __y__ = default(float);
            var __y__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadSingle();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadSingle();
                        __y__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float2();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;

            return ____result;
        }
    }


    public sealed class float2x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float2x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float2x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float2x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float2x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float2);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float2x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class float2x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float2x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float2x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float2x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float2x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.float2);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float2x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class float2x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float2x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float2x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float2x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float2x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.float2);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.float2);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float2x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class float3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.z);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(float);
            var __x__b__ = false;
            var __y__ = default(float);
            var __y__b__ = false;
            var __z__ = default(float);
            var __z__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadSingle();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadSingle();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadSingle();
                        __z__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float3();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;

            return ____result;
        }
    }


    public sealed class float3x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float3x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float3x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float3x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float3x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float3);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float3x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class float3x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float3x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float3x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float3x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float3x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.float3);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float3x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class float3x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float3x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float3x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float3x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float3x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.float3);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.float3);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float3x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class float4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.z);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.w);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(float);
            var __x__b__ = false;
            var __y__ = default(float);
            var __y__b__ = false;
            var __z__ = default(float);
            var __z__b__ = false;
            var __w__ = default(float);
            var __w__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadSingle();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadSingle();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadSingle();
                        __z__b__ = true;
                        break;
                    case 3:
                        __w__ = reader.ReadSingle();
                        __w__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float4();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;
            if(__w__b__) ____result.w = __w__;

            return ____result;
        }
    }


    public sealed class float4x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float4x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float4x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float4x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float4x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float4);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float4x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class float4x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float4x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float4x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float4x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float4x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.float4);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float4x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class float4x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.float4x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public float4x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.float4x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.float4x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.float4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.float4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.float4);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.float4);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.float4x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class halfFormatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.half>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public halfFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.half value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteUInt16(value.value);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.half Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __value__ = default(ushort);
            var __value__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = reader.ReadUInt16();
                        __value__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.half();
            if(__value__b__) ____result.value = __value__;

            return ____result;
        }
    }


    public sealed class half2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.half2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public half2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.half2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.x, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.y, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.half2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(global::Unity.Mathematics.half);
            var __x__b__ = false;
            var __y__ = default(global::Unity.Mathematics.half);
            var __y__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __y__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.half2();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;

            return ____result;
        }
    }


    public sealed class half3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.half3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public half3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.half3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.x, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.y, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.z, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.half3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(global::Unity.Mathematics.half);
            var __x__b__ = false;
            var __y__ = default(global::Unity.Mathematics.half);
            var __y__b__ = false;
            var __z__ = default(global::Unity.Mathematics.half);
            var __z__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __z__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.half3();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;

            return ____result;
        }
    }


    public sealed class half4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.half4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public half4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.half4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.x, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.y, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.z, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Serialize(ref writer, value.w, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.half4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(global::Unity.Mathematics.half);
            var __x__b__ = false;
            var __y__ = default(global::Unity.Mathematics.half);
            var __y__b__ = false;
            var __z__ = default(global::Unity.Mathematics.half);
            var __z__b__ = false;
            var __w__ = default(global::Unity.Mathematics.half);
            var __w__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __z__b__ = true;
                        break;
                    case 3:
                        __w__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.half>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __w__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.half4();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;
            if(__w__b__) ____result.w = __w__;

            return ____result;
        }
    }


    public sealed class int2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.y);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(int);
            var __x__b__ = false;
            var __y__ = default(int);
            var __y__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadInt32();
                        __y__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int2();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;

            return ____result;
        }
    }


    public sealed class int2x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int2x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int2x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int2x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int2x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int2);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int2x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class int2x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int2x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int2x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int2x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int2x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.int2);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int2x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class int2x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int2x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int2x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int2x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int2x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.int2);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.int2);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int2x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class int3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.z);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(int);
            var __x__b__ = false;
            var __y__ = default(int);
            var __y__b__ = false;
            var __z__ = default(int);
            var __z__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadInt32();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadInt32();
                        __z__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int3();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;

            return ____result;
        }
    }


    public sealed class int3x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int3x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int3x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int3x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int3x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int3);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int3x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class int3x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int3x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int3x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int3x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int3x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.int3);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int3x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class int3x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int3x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int3x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int3x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int3x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.int3);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.int3);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int3x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class int4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.z);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.w);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(int);
            var __x__b__ = false;
            var __y__ = default(int);
            var __y__b__ = false;
            var __z__ = default(int);
            var __z__b__ = false;
            var __w__ = default(int);
            var __w__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadInt32();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadInt32();
                        __z__b__ = true;
                        break;
                    case 3:
                        __w__ = reader.ReadInt32();
                        __w__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int4();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;
            if(__w__b__) ____result.w = __w__;

            return ____result;
        }
    }


    public sealed class int4x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int4x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int4x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int4x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int4x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int4);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int4x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class int4x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int4x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int4x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int4x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int4x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.int4);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int4x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class int4x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.int4x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public int4x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.int4x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.int4x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.int4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.int4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.int4);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.int4);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.int4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.int4x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class quaternionFormatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.quaternion>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public quaternionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.quaternion value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Serialize(ref writer, value.value, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.quaternion Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __value__ = default(global::Unity.Mathematics.float4);
            var __value__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.quaternion();
            if(__value__b__) ____result.value = __value__;

            return ____result;
        }
    }


    public sealed class RandomFormatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.Random>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RandomFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("state"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.Random value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteUInt32(value.state);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.Random Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __state__ = default(uint);
            var __state__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __state__ = reader.ReadUInt32();
                        __state__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.Random();
            if(__state__b__) ____result.state = __state__;

            return ____result;
        }
    }


    public sealed class RigidTransformFormatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.RigidTransform>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RigidTransformFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("rot"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("pos"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("rot"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pos"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.RigidTransform value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.quaternion>(formatterResolver).Serialize(ref writer, value.rot, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Serialize(ref writer, value.pos, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.RigidTransform Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __rot__ = default(global::Unity.Mathematics.quaternion);
            var __rot__b__ = false;
            var __pos__ = default(global::Unity.Mathematics.float3);
            var __pos__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __rot__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.quaternion>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __rot__b__ = true;
                        break;
                    case 1:
                        __pos__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.float3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __pos__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.RigidTransform();
            if(__rot__b__) ____result.rot = __rot__;
            if(__pos__b__) ____result.pos = __pos__;

            return ____result;
        }
    }


    public sealed class uint2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteUInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteUInt32(value.y);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(uint);
            var __x__b__ = false;
            var __y__ = default(uint);
            var __y__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadUInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadUInt32();
                        __y__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint2();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;

            return ____result;
        }
    }


    public sealed class uint2x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint2x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint2x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint2x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint2x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint2);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint2x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class uint2x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint2x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint2x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint2x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint2x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.uint2);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint2x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class uint2x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint2x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint2x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint2x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint2x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint2);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint2);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.uint2);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.uint2);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint2>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint2x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class uint3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteUInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteUInt32(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteUInt32(value.z);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(uint);
            var __x__b__ = false;
            var __y__ = default(uint);
            var __y__b__ = false;
            var __z__ = default(uint);
            var __z__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadUInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadUInt32();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadUInt32();
                        __z__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint3();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;

            return ____result;
        }
    }


    public sealed class uint3x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint3x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint3x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint3x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint3x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint3);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint3x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class uint3x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint3x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint3x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint3x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint3x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.uint3);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint3x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class uint3x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint3x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint3x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint3x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint3x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint3);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint3);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.uint3);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.uint3);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint3>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint3x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }


    public sealed class uint4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteUInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteUInt32(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteUInt32(value.z);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteUInt32(value.w);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(uint);
            var __x__b__ = false;
            var __y__ = default(uint);
            var __y__b__ = false;
            var __z__ = default(uint);
            var __z__b__ = false;
            var __w__ = default(uint);
            var __w__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadUInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadUInt32();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadUInt32();
                        __z__b__ = true;
                        break;
                    case 3:
                        __w__ = reader.ReadUInt32();
                        __w__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint4();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;
            if(__w__b__) ____result.w = __w__;

            return ____result;
        }
    }


    public sealed class uint4x2Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint4x2>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint4x2Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint4x2 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint4x2 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint4);
            var __c1__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint4x2();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;

            return ____result;
        }
    }


    public sealed class uint4x3Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint4x3>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint4x3Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint4x3 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint4x3 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.uint4);
            var __c2__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint4x3();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;

            return ____result;
        }
    }


    public sealed class uint4x4Formatter : global::Utf8Json.IJsonFormatter<global::Unity.Mathematics.uint4x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public uint4x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c0"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c1"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c2"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("c3"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("c0"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c1"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c2"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c3"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::Unity.Mathematics.uint4x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c0, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c1, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c2, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Serialize(ref writer, value.c3, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Unity.Mathematics.uint4x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __c0__ = default(global::Unity.Mathematics.uint4);
            var __c0__b__ = false;
            var __c1__ = default(global::Unity.Mathematics.uint4);
            var __c1__b__ = false;
            var __c2__ = default(global::Unity.Mathematics.uint4);
            var __c2__b__ = false;
            var __c3__ = default(global::Unity.Mathematics.uint4);
            var __c3__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __c0__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c0__b__ = true;
                        break;
                    case 1:
                        __c1__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c1__b__ = true;
                        break;
                    case 2:
                        __c2__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c2__b__ = true;
                        break;
                    case 3:
                        __c3__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::Unity.Mathematics.uint4>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __c3__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Unity.Mathematics.uint4x4();
            if(__c0__b__) ____result.c0 = __c0__;
            if(__c1__b__) ____result.c1 = __c1__;
            if(__c2__b__) ____result.c2 = __c2__;
            if(__c3__b__) ____result.c3 = __c3__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace UGF.Module.Serialize.Utf8Json.Runtime.Formatters.UnityEngine
{
    using System;
    using Utf8Json;


    public sealed class KeyframeFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.Keyframe>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public KeyframeFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("time"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("inTangent"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("outTangent"), 3},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("inWeight"), 4},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("outWeight"), 5},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("weightedMode"), 6},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("tangentMode"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("time"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("value"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("inTangent"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("outTangent"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("inWeight"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("outWeight"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weightedMode"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tangentMode"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.Keyframe value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.time);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.value);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.inTangent);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.outTangent);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.inWeight);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.outWeight);
            writer.WriteRaw(this.____stringByteKeys[6]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WeightedMode>(formatterResolver).Serialize(ref writer, value.weightedMode, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.tangentMode);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.Keyframe Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __time__ = default(float);
            var __time__b__ = false;
            var __value__ = default(float);
            var __value__b__ = false;
            var __inTangent__ = default(float);
            var __inTangent__b__ = false;
            var __outTangent__ = default(float);
            var __outTangent__b__ = false;
            var __inWeight__ = default(float);
            var __inWeight__b__ = false;
            var __outWeight__ = default(float);
            var __outWeight__b__ = false;
            var __weightedMode__ = default(global::UnityEngine.WeightedMode);
            var __weightedMode__b__ = false;
            var __tangentMode__ = default(int);
            var __tangentMode__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __time__ = reader.ReadSingle();
                        __time__b__ = true;
                        break;
                    case 1:
                        __value__ = reader.ReadSingle();
                        __value__b__ = true;
                        break;
                    case 2:
                        __inTangent__ = reader.ReadSingle();
                        __inTangent__b__ = true;
                        break;
                    case 3:
                        __outTangent__ = reader.ReadSingle();
                        __outTangent__b__ = true;
                        break;
                    case 4:
                        __inWeight__ = reader.ReadSingle();
                        __inWeight__b__ = true;
                        break;
                    case 5:
                        __outWeight__ = reader.ReadSingle();
                        __outWeight__b__ = true;
                        break;
                    case 6:
                        __weightedMode__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WeightedMode>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __weightedMode__b__ = true;
                        break;
                    case 7:
                        __tangentMode__ = reader.ReadInt32();
                        __tangentMode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.Keyframe();
            if(__time__b__) ____result.time = __time__;
            if(__value__b__) ____result.value = __value__;
            if(__inTangent__b__) ____result.inTangent = __inTangent__;
            if(__outTangent__b__) ____result.outTangent = __outTangent__;
            if(__inWeight__b__) ____result.inWeight = __inWeight__;
            if(__outWeight__b__) ____result.outWeight = __outWeight__;
            if(__weightedMode__b__) ____result.weightedMode = __weightedMode__;
            if(__tangentMode__b__) ____result.tangentMode = __tangentMode__;

            return ____result;
        }
    }


    public sealed class AnimationCurveFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.AnimationCurve>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AnimationCurveFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("keys"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("preWrapMode"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("postWrapMode"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("keys"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("preWrapMode"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("postWrapMode"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.AnimationCurve value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Keyframe[]>(formatterResolver).Serialize(ref writer, value.keys, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WrapMode>(formatterResolver).Serialize(ref writer, value.preWrapMode, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WrapMode>(formatterResolver).Serialize(ref writer, value.postWrapMode, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.AnimationCurve Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __keys__ = default(global::UnityEngine.Keyframe[]);
            var __keys__b__ = false;
            var __preWrapMode__ = default(global::UnityEngine.WrapMode);
            var __preWrapMode__b__ = false;
            var __postWrapMode__ = default(global::UnityEngine.WrapMode);
            var __postWrapMode__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __keys__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Keyframe[]>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __keys__b__ = true;
                        break;
                    case 1:
                        __preWrapMode__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WrapMode>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __preWrapMode__b__ = true;
                        break;
                    case 2:
                        __postWrapMode__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WrapMode>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __postWrapMode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.AnimationCurve();
            if(__keys__b__) ____result.keys = __keys__;
            if(__preWrapMode__b__) ____result.preWrapMode = __preWrapMode__;
            if(__postWrapMode__b__) ____result.postWrapMode = __postWrapMode__;

            return ____result;
        }
    }


    public sealed class Vector3IntFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.Vector3Int>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Vector3IntFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("z"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("z"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.Vector3Int value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.z);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.Vector3Int Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(int);
            var __x__b__ = false;
            var __y__ = default(int);
            var __y__b__ = false;
            var __z__ = default(int);
            var __z__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadInt32();
                        __y__b__ = true;
                        break;
                    case 2:
                        __z__ = reader.ReadInt32();
                        __z__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.Vector3Int();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__z__b__) ____result.z = __z__;

            return ____result;
        }
    }


    public sealed class BoundsIntFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.BoundsInt>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BoundsIntFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("position"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("size"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("position"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("size"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.BoundsInt value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Vector3Int>(formatterResolver).Serialize(ref writer, value.position, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Vector3Int>(formatterResolver).Serialize(ref writer, value.size, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.BoundsInt Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __position__ = default(global::UnityEngine.Vector3Int);
            var __position__b__ = false;
            var __size__ = default(global::UnityEngine.Vector3Int);
            var __size__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __position__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Vector3Int>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __position__b__ = true;
                        break;
                    case 1:
                        __size__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Vector3Int>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __size__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.BoundsInt();
            if(__position__b__) ____result.position = __position__;
            if(__size__b__) ____result.size = __size__;

            return ____result;
        }
    }


    public sealed class Color32Formatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.Color32>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Color32Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("r"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("g"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("b"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("a"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("r"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("g"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("b"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("a"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.Color32 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteByte(value.r);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteByte(value.g);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteByte(value.b);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteByte(value.a);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.Color32 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __r__ = default(byte);
            var __r__b__ = false;
            var __g__ = default(byte);
            var __g__b__ = false;
            var __b__ = default(byte);
            var __b__b__ = false;
            var __a__ = default(byte);
            var __a__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __r__ = reader.ReadByte();
                        __r__b__ = true;
                        break;
                    case 1:
                        __g__ = reader.ReadByte();
                        __g__b__ = true;
                        break;
                    case 2:
                        __b__ = reader.ReadByte();
                        __b__b__ = true;
                        break;
                    case 3:
                        __a__ = reader.ReadByte();
                        __a__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.Color32();
            if(__r__b__) ____result.r = __r__;
            if(__g__b__) ____result.g = __g__;
            if(__b__b__) ____result.b = __b__;
            if(__a__b__) ____result.a = __a__;

            return ____result;
        }
    }


    public sealed class GradientColorKeyFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.GradientColorKey>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GradientColorKeyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("color"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("time"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("color"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("time"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.GradientColorKey value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Color>(formatterResolver).Serialize(ref writer, value.color, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.time);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.GradientColorKey Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __color__ = default(global::UnityEngine.Color);
            var __color__b__ = false;
            var __time__ = default(float);
            var __time__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __color__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.Color>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __color__b__ = true;
                        break;
                    case 1:
                        __time__ = reader.ReadSingle();
                        __time__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.GradientColorKey();
            if(__color__b__) ____result.color = __color__;
            if(__time__b__) ____result.time = __time__;

            return ____result;
        }
    }


    public sealed class GradientAlphaKeyFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.GradientAlphaKey>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GradientAlphaKeyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("alpha"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("time"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("alpha"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("time"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.GradientAlphaKey value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.alpha);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.time);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.GradientAlphaKey Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __alpha__ = default(float);
            var __alpha__b__ = false;
            var __time__ = default(float);
            var __time__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __alpha__ = reader.ReadSingle();
                        __alpha__b__ = true;
                        break;
                    case 1:
                        __time__ = reader.ReadSingle();
                        __time__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.GradientAlphaKey();
            if(__alpha__b__) ____result.alpha = __alpha__;
            if(__time__b__) ____result.time = __time__;

            return ____result;
        }
    }


    public sealed class GradientFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.Gradient>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GradientFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("colorKeys"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("alphaKeys"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("mode"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("colorKeys"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("alphaKeys"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mode"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.Gradient value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.GradientColorKey[]>(formatterResolver).Serialize(ref writer, value.colorKeys, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.GradientAlphaKey[]>(formatterResolver).Serialize(ref writer, value.alphaKeys, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.GradientMode>(formatterResolver).Serialize(ref writer, value.mode, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.Gradient Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __colorKeys__ = default(global::UnityEngine.GradientColorKey[]);
            var __colorKeys__b__ = false;
            var __alphaKeys__ = default(global::UnityEngine.GradientAlphaKey[]);
            var __alphaKeys__b__ = false;
            var __mode__ = default(global::UnityEngine.GradientMode);
            var __mode__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __colorKeys__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.GradientColorKey[]>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __colorKeys__b__ = true;
                        break;
                    case 1:
                        __alphaKeys__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.GradientAlphaKey[]>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __alphaKeys__b__ = true;
                        break;
                    case 2:
                        __mode__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.GradientMode>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __mode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.Gradient();
            if(__colorKeys__b__) ____result.colorKeys = __colorKeys__;
            if(__alphaKeys__b__) ____result.alphaKeys = __alphaKeys__;
            if(__mode__b__) ____result.mode = __mode__;

            return ____result;
        }
    }


    public sealed class LayerMaskFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.LayerMask>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LayerMaskFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.LayerMask value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.value);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.LayerMask Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __value__ = default(int);
            var __value__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = reader.ReadInt32();
                        __value__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.LayerMask();
            if(__value__b__) ____result.value = __value__;

            return ____result;
        }
    }


    public sealed class Matrix4x4Formatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.Matrix4x4>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Matrix4x4Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m00"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m10"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m20"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m30"), 3},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m01"), 4},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m11"), 5},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m21"), 6},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m31"), 7},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m02"), 8},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m12"), 9},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m22"), 10},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m32"), 11},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m03"), 12},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m13"), 13},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m23"), 14},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("m33"), 15},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("m00"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m10"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m20"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m30"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m01"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m11"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m21"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m31"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m02"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m12"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m22"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m32"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m03"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m13"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m23"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("m33"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.Matrix4x4 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.m00);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.m10);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.m20);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.m30);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.m01);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.m11);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.m21);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteSingle(value.m31);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteSingle(value.m02);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteSingle(value.m12);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteSingle(value.m22);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteSingle(value.m32);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteSingle(value.m03);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteSingle(value.m13);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteSingle(value.m23);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteSingle(value.m33);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.Matrix4x4 Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __m00__ = default(float);
            var __m00__b__ = false;
            var __m10__ = default(float);
            var __m10__b__ = false;
            var __m20__ = default(float);
            var __m20__b__ = false;
            var __m30__ = default(float);
            var __m30__b__ = false;
            var __m01__ = default(float);
            var __m01__b__ = false;
            var __m11__ = default(float);
            var __m11__b__ = false;
            var __m21__ = default(float);
            var __m21__b__ = false;
            var __m31__ = default(float);
            var __m31__b__ = false;
            var __m02__ = default(float);
            var __m02__b__ = false;
            var __m12__ = default(float);
            var __m12__b__ = false;
            var __m22__ = default(float);
            var __m22__b__ = false;
            var __m32__ = default(float);
            var __m32__b__ = false;
            var __m03__ = default(float);
            var __m03__b__ = false;
            var __m13__ = default(float);
            var __m13__b__ = false;
            var __m23__ = default(float);
            var __m23__b__ = false;
            var __m33__ = default(float);
            var __m33__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __m00__ = reader.ReadSingle();
                        __m00__b__ = true;
                        break;
                    case 1:
                        __m10__ = reader.ReadSingle();
                        __m10__b__ = true;
                        break;
                    case 2:
                        __m20__ = reader.ReadSingle();
                        __m20__b__ = true;
                        break;
                    case 3:
                        __m30__ = reader.ReadSingle();
                        __m30__b__ = true;
                        break;
                    case 4:
                        __m01__ = reader.ReadSingle();
                        __m01__b__ = true;
                        break;
                    case 5:
                        __m11__ = reader.ReadSingle();
                        __m11__b__ = true;
                        break;
                    case 6:
                        __m21__ = reader.ReadSingle();
                        __m21__b__ = true;
                        break;
                    case 7:
                        __m31__ = reader.ReadSingle();
                        __m31__b__ = true;
                        break;
                    case 8:
                        __m02__ = reader.ReadSingle();
                        __m02__b__ = true;
                        break;
                    case 9:
                        __m12__ = reader.ReadSingle();
                        __m12__b__ = true;
                        break;
                    case 10:
                        __m22__ = reader.ReadSingle();
                        __m22__b__ = true;
                        break;
                    case 11:
                        __m32__ = reader.ReadSingle();
                        __m32__b__ = true;
                        break;
                    case 12:
                        __m03__ = reader.ReadSingle();
                        __m03__b__ = true;
                        break;
                    case 13:
                        __m13__ = reader.ReadSingle();
                        __m13__b__ = true;
                        break;
                    case 14:
                        __m23__ = reader.ReadSingle();
                        __m23__b__ = true;
                        break;
                    case 15:
                        __m33__ = reader.ReadSingle();
                        __m33__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.Matrix4x4();
            if(__m00__b__) ____result.m00 = __m00__;
            if(__m10__b__) ____result.m10 = __m10__;
            if(__m20__b__) ____result.m20 = __m20__;
            if(__m30__b__) ____result.m30 = __m30__;
            if(__m01__b__) ____result.m01 = __m01__;
            if(__m11__b__) ____result.m11 = __m11__;
            if(__m21__b__) ____result.m21 = __m21__;
            if(__m31__b__) ____result.m31 = __m31__;
            if(__m02__b__) ____result.m02 = __m02__;
            if(__m12__b__) ____result.m12 = __m12__;
            if(__m22__b__) ____result.m22 = __m22__;
            if(__m32__b__) ____result.m32 = __m32__;
            if(__m03__b__) ____result.m03 = __m03__;
            if(__m13__b__) ____result.m13 = __m13__;
            if(__m23__b__) ____result.m23 = __m23__;
            if(__m33__b__) ____result.m33 = __m33__;

            return ____result;
        }
    }


    public sealed class RangeIntFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.RangeInt>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RangeIntFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("start"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("length"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("start"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("length"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.RangeInt value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.start);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.length);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.RangeInt Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __start__ = default(int);
            var __start__b__ = false;
            var __length__ = default(int);
            var __length__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __start__ = reader.ReadInt32();
                        __start__b__ = true;
                        break;
                    case 1:
                        __length__ = reader.ReadInt32();
                        __length__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.RangeInt();
            if(__start__b__) ____result.start = __start__;
            if(__length__b__) ____result.length = __length__;

            return ____result;
        }
    }


    public sealed class RectIntFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.RectInt>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RectIntFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("width"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("height"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("width"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("height"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.RectInt value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.y);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.width);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.height);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.RectInt Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(int);
            var __x__b__ = false;
            var __y__ = default(int);
            var __y__b__ = false;
            var __width__ = default(int);
            var __width__b__ = false;
            var __height__ = default(int);
            var __height__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadInt32();
                        __y__b__ = true;
                        break;
                    case 2:
                        __width__ = reader.ReadInt32();
                        __width__b__ = true;
                        break;
                    case 3:
                        __height__ = reader.ReadInt32();
                        __height__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.RectInt();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;
            if(__width__b__) ____result.width = __width__;
            if(__height__b__) ____result.height = __height__;

            return ____result;
        }
    }


    public sealed class RectOffsetFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.RectOffset>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RectOffsetFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("left"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("right"), 1},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("top"), 2},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("bottom"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("left"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("right"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("top"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bottom"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.RectOffset value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.left);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.right);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.top);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.bottom);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.RectOffset Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __left__ = default(int);
            var __left__b__ = false;
            var __right__ = default(int);
            var __right__b__ = false;
            var __top__ = default(int);
            var __top__b__ = false;
            var __bottom__ = default(int);
            var __bottom__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __left__ = reader.ReadInt32();
                        __left__b__ = true;
                        break;
                    case 1:
                        __right__ = reader.ReadInt32();
                        __right__b__ = true;
                        break;
                    case 2:
                        __top__ = reader.ReadInt32();
                        __top__b__ = true;
                        break;
                    case 3:
                        __bottom__ = reader.ReadInt32();
                        __bottom__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.RectOffset();
            if(__left__b__) ____result.left = __left__;
            if(__right__b__) ____result.right = __right__;
            if(__top__b__) ____result.top = __top__;
            if(__bottom__b__) ____result.bottom = __bottom__;

            return ____result;
        }
    }


    public sealed class Vector2IntFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.Vector2Int>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Vector2IntFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("x"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("y"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("x"),
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("y"),
                
            };
        }

        public void Serialize(ref global::Utf8Json.JsonWriter writer, global::UnityEngine.Vector2Int value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.x);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.y);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.Vector2Int Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }
            

            var __x__ = default(int);
            var __x__b__ = false;
            var __y__ = default(int);
            var __y__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValue(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __x__ = reader.ReadInt32();
                        __x__b__ = true;
                        break;
                    case 1:
                        __y__ = reader.ReadInt32();
                        __y__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::UnityEngine.Vector2Int();
            if(__x__b__) ____result.x = __x__;
            if(__y__b__) ____result.y = __y__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
