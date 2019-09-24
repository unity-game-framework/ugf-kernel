using System;
using UGF.Serialize.Runtime;
using UGF.Utf8Json.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializerUtf8JsonBytes : SerializerBase<byte[]>
    {
        public IUtf8JsonFormatterResolver Resolver { get; }

        public SerializerUtf8JsonBytes(IUtf8JsonFormatterResolver resolver)
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
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));
            if (data == null) throw new ArgumentNullException(nameof(data));

            if (Resolver.TryGetFormatter(targetType, out IJsonFormatter value) && value is IJsonFormatter<object> formatter)
            {
                var reader = new JsonReader(data);

                return formatter.Deserialize(ref reader, Resolver);
            }

            throw new ArgumentException($"The typeless formatter for the specified target type not found: '{targetType}', type: '{typeof(object)}'.", nameof(targetType));
        }
    }
}
