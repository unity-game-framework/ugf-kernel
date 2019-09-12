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
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(9)
            {
                {typeof(global::Unity.Mathematics.bool2), 0 },
                {typeof(global::Unity.Mathematics.bool2x2), 1 },
                {typeof(global::Unity.Mathematics.bool2x3), 2 },
                {typeof(global::Unity.Mathematics.bool2x4), 3 },
                {typeof(global::Unity.Mathematics.bool3), 4 },
                {typeof(global::Unity.Mathematics.bool4), 5 },
                {typeof(global::Unity.Mathematics.int2), 6 },
                {typeof(global::Unity.Mathematics.int3), 7 },
                {typeof(global::Unity.Mathematics.int4), 8 },
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
                case 5: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.bool4Formatter();
                case 6: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int2Formatter();
                case 7: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int3Formatter();
                case 8: return new UGF.Serialize.Utf8Json.Math.Runtime.Formatters.Unity.Mathematics.int4Formatter();
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

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
