// THIS IS A GENERATED CODE. DO NOT EDIT.
// ReSharper disable all

namespace UGF.Serialize.Utf8Json.Resolvers
{
    using System;
    using Utf8Json;

    public class UGFSerializeUtf8JsonResolver : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new UGFSerializeUtf8JsonResolver();

        UGFSerializeUtf8JsonResolver()
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
                var f = UGFSerializeUtf8JsonResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class UGFSerializeUtf8JsonResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static UGFSerializeUtf8JsonResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(17)
            {
                {typeof(global::UnityEngine.WrapMode), 0 },
                {typeof(global::UnityEngine.GradientMode), 1 },
                {typeof(global::UnityEngine.WeightedMode), 2 },
                {typeof(global::UnityEngine.AnimationCurve), 3 },
                {typeof(global::UnityEngine.Vector3Int), 4 },
                {typeof(global::UnityEngine.BoundsInt), 5 },
                {typeof(global::UnityEngine.Color32), 6 },
                {typeof(global::UnityEngine.Gradient), 7 },
                {typeof(global::UnityEngine.GradientAlphaKey), 8 },
                {typeof(global::UnityEngine.GradientColorKey), 9 },
                {typeof(global::UnityEngine.Keyframe), 10 },
                {typeof(global::UnityEngine.LayerMask), 11 },
                {typeof(global::UnityEngine.Matrix4x4), 12 },
                {typeof(global::UnityEngine.RangeInt), 13 },
                {typeof(global::UnityEngine.RectInt), 14 },
                {typeof(global::UnityEngine.RectOffset), 15 },
                {typeof(global::UnityEngine.Vector2Int), 16 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.WrapModeFormatter();
                case 1: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.GradientModeFormatter();
                case 2: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.WeightedModeFormatter();
                case 3: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.AnimationCurveFormatter();
                case 4: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.Vector3IntFormatter();
                case 5: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.BoundsIntFormatter();
                case 6: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.Color32Formatter();
                case 7: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.GradientFormatter();
                case 8: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.GradientAlphaKeyFormatter();
                case 9: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.GradientColorKeyFormatter();
                case 10: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.KeyframeFormatter();
                case 11: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.LayerMaskFormatter();
                case 12: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.Matrix4x4Formatter();
                case 13: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.RangeIntFormatter();
                case 14: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.RectIntFormatter();
                case 15: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.RectOffsetFormatter();
                case 16: return new UGF.Serialize.Utf8Json.Formatters.UnityEngine.Vector2IntFormatter();
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

namespace UGF.Serialize.Utf8Json.Formatters.UnityEngine
{
    using System;
    using Utf8Json;

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

namespace UGF.Serialize.Utf8Json.Formatters.UnityEngine
{
    using System;
    using Utf8Json;


    public sealed class AnimationCurveFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.AnimationCurve>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AnimationCurveFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("preWrapMode"), 0},
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("postWrapMode"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("preWrapMode"),
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
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WrapMode>(formatterResolver).Serialize(ref writer, value.preWrapMode, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WrapMode>(formatterResolver).Serialize(ref writer, value.postWrapMode, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.AnimationCurve Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

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
                        __preWrapMode__ = global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.WrapMode>(formatterResolver).Deserialize(ref reader, formatterResolver);
                        __preWrapMode__b__ = true;
                        break;
                    case 1:
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


    public sealed class GradientFormatter : global::Utf8Json.IJsonFormatter<global::UnityEngine.Gradient>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GradientFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithoutQuotation("mode"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                global::Utf8Json.JsonWriter.GetEncodedPropertyNameWithBeginObject("mode"),
                
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
            global::Utf8Json.JsonFormatterResolverExtensions.GetFormatterWithVerify<global::UnityEngine.GradientMode>(formatterResolver).Serialize(ref writer, value.mode, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::UnityEngine.Gradient Deserialize(ref global::Utf8Json.JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

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
            if(__mode__b__) ____result.mode = __mode__;

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
