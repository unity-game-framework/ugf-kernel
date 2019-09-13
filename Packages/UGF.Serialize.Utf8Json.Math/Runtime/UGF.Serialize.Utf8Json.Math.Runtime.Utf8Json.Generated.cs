// THIS IS A GENERATED CODE. DO NOT EDIT.
// ReSharper disable all

namespace UGF.Serialize.Utf8Json.Math.Runtime.Resolvers
{
    using System;
    using Utf8Json;

    public class UGFSerializeUtf8JsonMathRuntimeResolver : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new UGFSerializeUtf8JsonMathRuntimeResolver();

        UGFSerializeUtf8JsonMathRuntimeResolver()
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
                var f = UGFSerializeUtf8JsonMathRuntimeResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class UGFSerializeUtf8JsonMathRuntimeResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static UGFSerializeUtf8JsonMathRuntimeResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(67)
            {
                {typeof(global::Unity.Mathematics.bool2), 0 },
                {typeof(global::Unity.Mathematics.bool2x2), 1 },
                {typeof(global::Unity.Mathematics.bool2x3), 2 },
                {typeof(global::Unity.Mathematics.bool2x4), 3 },
                {typeof(global::Unity.Mathematics.bool3), 4 },
                {typeof(global::Unity.Mathematics.bool3x2), 5 },
                {typeof(global::Unity.Mathematics.bool3x3), 6 },
                {typeof(global::Unity.Mathematics.bool3x4), 7 },
                {typeof(global::Unity.Mathematics.bool4), 8 },
                {typeof(global::Unity.Mathematics.bool4x2), 9 },
                {typeof(global::Unity.Mathematics.bool4x3), 10 },
                {typeof(global::Unity.Mathematics.bool4x4), 11 },
                {typeof(global::Unity.Mathematics.double2), 12 },
                {typeof(global::Unity.Mathematics.double2x2), 13 },
                {typeof(global::Unity.Mathematics.double2x3), 14 },
                {typeof(global::Unity.Mathematics.double2x4), 15 },
                {typeof(global::Unity.Mathematics.double3), 16 },
                {typeof(global::Unity.Mathematics.double3x2), 17 },
                {typeof(global::Unity.Mathematics.double3x3), 18 },
                {typeof(global::Unity.Mathematics.double3x4), 19 },
                {typeof(global::Unity.Mathematics.double4), 20 },
                {typeof(global::Unity.Mathematics.double4x2), 21 },
                {typeof(global::Unity.Mathematics.double4x3), 22 },
                {typeof(global::Unity.Mathematics.double4x4), 23 },
                {typeof(global::Unity.Mathematics.float2), 24 },
                {typeof(global::Unity.Mathematics.float2x2), 25 },
                {typeof(global::Unity.Mathematics.float2x3), 26 },
                {typeof(global::Unity.Mathematics.float2x4), 27 },
                {typeof(global::Unity.Mathematics.float3), 28 },
                {typeof(global::Unity.Mathematics.float3x2), 29 },
                {typeof(global::Unity.Mathematics.float3x3), 30 },
                {typeof(global::Unity.Mathematics.float3x4), 31 },
                {typeof(global::Unity.Mathematics.float4), 32 },
                {typeof(global::Unity.Mathematics.float4x2), 33 },
                {typeof(global::Unity.Mathematics.float4x3), 34 },
                {typeof(global::Unity.Mathematics.float4x4), 35 },
                {typeof(global::Unity.Mathematics.half), 36 },
                {typeof(global::Unity.Mathematics.half2), 37 },
                {typeof(global::Unity.Mathematics.half3), 38 },
                {typeof(global::Unity.Mathematics.half4), 39 },
                {typeof(global::Unity.Mathematics.int2), 40 },
                {typeof(global::Unity.Mathematics.int2x2), 41 },
                {typeof(global::Unity.Mathematics.int2x3), 42 },
                {typeof(global::Unity.Mathematics.int2x4), 43 },
                {typeof(global::Unity.Mathematics.int3), 44 },
                {typeof(global::Unity.Mathematics.int3x2), 45 },
                {typeof(global::Unity.Mathematics.int3x3), 46 },
                {typeof(global::Unity.Mathematics.int3x4), 47 },
                {typeof(global::Unity.Mathematics.int4), 48 },
                {typeof(global::Unity.Mathematics.int4x2), 49 },
                {typeof(global::Unity.Mathematics.int4x3), 50 },
                {typeof(global::Unity.Mathematics.int4x4), 51 },
                {typeof(global::Unity.Mathematics.quaternion), 52 },
                {typeof(global::Unity.Mathematics.Random), 53 },
                {typeof(global::Unity.Mathematics.RigidTransform), 54 },
                {typeof(global::Unity.Mathematics.uint2), 55 },
                {typeof(global::Unity.Mathematics.uint2x2), 56 },
                {typeof(global::Unity.Mathematics.uint2x3), 57 },
                {typeof(global::Unity.Mathematics.uint2x4), 58 },
                {typeof(global::Unity.Mathematics.uint3), 59 },
                {typeof(global::Unity.Mathematics.uint3x2), 60 },
                {typeof(global::Unity.Mathematics.uint3x3), 61 },
                {typeof(global::Unity.Mathematics.uint3x4), 62 },
                {typeof(global::Unity.Mathematics.uint4), 63 },
                {typeof(global::Unity.Mathematics.uint4x2), 64 },
                {typeof(global::Unity.Mathematics.uint4x3), 65 },
                {typeof(global::Unity.Mathematics.uint4x4), 66 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool2Formatter();
                case 1: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool2x2Formatter();
                case 2: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool2x3Formatter();
                case 3: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool2x4Formatter();
                case 4: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool3Formatter();
                case 5: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool3x2Formatter();
                case 6: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool3x3Formatter();
                case 7: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool3x4Formatter();
                case 8: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool4Formatter();
                case 9: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool4x2Formatter();
                case 10: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool4x3Formatter();
                case 11: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool4x4Formatter();
                case 12: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double2Formatter();
                case 13: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double2x2Formatter();
                case 14: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double2x3Formatter();
                case 15: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double2x4Formatter();
                case 16: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double3Formatter();
                case 17: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double3x2Formatter();
                case 18: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double3x3Formatter();
                case 19: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double3x4Formatter();
                case 20: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double4Formatter();
                case 21: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double4x2Formatter();
                case 22: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double4x3Formatter();
                case 23: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.double4x4Formatter();
                case 24: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float2Formatter();
                case 25: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float2x2Formatter();
                case 26: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float2x3Formatter();
                case 27: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float2x4Formatter();
                case 28: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float3Formatter();
                case 29: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float3x2Formatter();
                case 30: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float3x3Formatter();
                case 31: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float3x4Formatter();
                case 32: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float4Formatter();
                case 33: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float4x2Formatter();
                case 34: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float4x3Formatter();
                case 35: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.float4x4Formatter();
                case 36: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.halfFormatter();
                case 37: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.half2Formatter();
                case 38: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.half3Formatter();
                case 39: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.half4Formatter();
                case 40: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int2Formatter();
                case 41: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int2x2Formatter();
                case 42: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int2x3Formatter();
                case 43: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int2x4Formatter();
                case 44: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int3Formatter();
                case 45: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int3x2Formatter();
                case 46: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int3x3Formatter();
                case 47: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int3x4Formatter();
                case 48: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int4Formatter();
                case 49: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int4x2Formatter();
                case 50: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int4x3Formatter();
                case 51: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int4x4Formatter();
                case 52: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.quaternionFormatter();
                case 53: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.RandomFormatter();
                case 54: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.RigidTransformFormatter();
                case 55: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint2Formatter();
                case 56: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint2x2Formatter();
                case 57: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint2x3Formatter();
                case 58: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint2x4Formatter();
                case 59: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint3Formatter();
                case 60: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint3x2Formatter();
                case 61: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint3x3Formatter();
                case 62: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint3x4Formatter();
                case 63: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint4Formatter();
                case 64: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint4x2Formatter();
                case 65: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint4x3Formatter();
                case 66: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.uint4x4Formatter();
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
#pragma warning disable 219
#pragma warning disable 168

namespace UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics
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
