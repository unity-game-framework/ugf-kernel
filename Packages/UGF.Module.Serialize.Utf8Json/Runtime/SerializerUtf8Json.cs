using System;
using System.Text;
using UGF.Serialize.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializerUtf8Json : SerializerBase<string>
    {
        public IJsonFormatterResolver Resolver { get; }
        public bool Readable { get; }

        public SerializerUtf8Json(IJsonFormatterResolver resolver, bool readable)
        {
            Resolver = resolver;
            Readable = readable;
        }

        public override string Serialize<T>(T target)
        {
            var writer = new JsonWriter();
            IJsonFormatter<T> formatter = Resolver.GetFormatter<T>();

            formatter.Serialize(ref writer, target, Resolver);

            byte[] bytes = writer.ToUtf8ByteArray();
            string text = Readable ? JsonSerializer.PrettyPrint(bytes) : writer.ToString();

            return text;
        }

        public override T Deserialize<T>(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            var reader = new JsonReader(bytes);
            IJsonFormatter<T> formatter = Resolver.GetFormatter<T>();

            return formatter.Deserialize(ref reader, Resolver);
        }

        public override string Serialize(object target)
        {
            throw new NotSupportedException("Utf8Json: an abstract typeless serialization not supported.");
        }

        public override object Deserialize(Type targetType, string data)
        {
            throw new NotSupportedException("Utf8Json: an abstract typeless serialization not supported.");
        }
    }
}
