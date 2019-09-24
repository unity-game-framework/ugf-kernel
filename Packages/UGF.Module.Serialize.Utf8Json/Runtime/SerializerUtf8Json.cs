using System;
using System.Text;
using UGF.Serialize.Runtime;
using UGF.Utf8Json.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializerUtf8Json : SerializerBase<string>
    {
        public IUtf8JsonFormatterResolver Resolver { get; }
        public bool Readable { get; }

        public SerializerUtf8Json(IUtf8JsonFormatterResolver resolver, bool readable)
        {
            Resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
            Readable = readable;
        }

        public override string Serialize<T>(T target)
        {
            if (target == null) throw new ArgumentNullException(nameof(target));

            var writer = new JsonWriter();
            IJsonFormatter<T> formatter = Resolver.GetFormatter<T>();

            formatter.Serialize(ref writer, target, Resolver);

            byte[] bytes = writer.ToUtf8ByteArray();
            string text = Readable ? JsonSerializer.PrettyPrint(bytes) : writer.ToString();

            return text;
        }

        public override T Deserialize<T>(string data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

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
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));
            if (data == null) throw new ArgumentNullException(nameof(data));

            if (Resolver.TryGetFormatter(targetType, out IJsonFormatter value) && value is IJsonFormatter<object> formatter)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                var reader = new JsonReader(bytes);

                return formatter.Deserialize(ref reader, Resolver);
            }

            throw new ArgumentException($"The typeless formatter for the specified target type not found: '{targetType}', type: '{typeof(object)}'.", nameof(targetType));
        }
    }
}
