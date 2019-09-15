using System;
using UGF.Serialize.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializerUtf8JsonBytes : SerializerBase<byte[]>
    {
        public IJsonFormatterResolver Resolver { get; }

        public SerializerUtf8JsonBytes(IJsonFormatterResolver resolver)
        {
            Resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
        }

        public override byte[] Serialize<T>(T target)
        {
            if (target == null) throw new ArgumentNullException(nameof(target));

            var writer = new JsonWriter();
            IJsonFormatter<T> formatter = Resolver.GetFormatter<T>();

            formatter.Serialize(ref writer, target, Resolver);

            return writer.ToUtf8ByteArray();
        }

        public override T Deserialize<T>(byte[] data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            var reader = new JsonReader(data);
            IJsonFormatter<T> formatter = Resolver.GetFormatter<T>();

            return formatter.Deserialize(ref reader, Resolver);
        }

        public override byte[] Serialize(object target)
        {
            throw new NotSupportedException("Utf8Json: an abstract typeless serialization not supported.");
        }

        public override object Deserialize(Type targetType, byte[] data)
        {
            throw new NotSupportedException("Utf8Json: an abstract typeless serialization not supported.");
        }
    }
}
