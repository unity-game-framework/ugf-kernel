using System;
using UGF.Serialize.Runtime;
using UGF.Utf8Json.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializerUtf8JsonBytes : SerializerBase<byte[]>
    {
        public IUtf8JsonFormatterResolver Resolver { get; }
        public ISerializeUtf8JsonUnionProvider UnionTypeProvider { get; }

        public SerializerUtf8JsonBytes(IUtf8JsonFormatterResolver resolver, ISerializeUtf8JsonUnionProvider unionTypeProvider)
        {
            Resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
            UnionTypeProvider = unionTypeProvider ?? throw new ArgumentNullException(nameof(unionTypeProvider));
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
            if (target == null) throw new ArgumentNullException(nameof(target));

            Type targetType = target.GetType();
            var writer = new JsonWriter();
            IJsonFormatter<object> formatter = GetTypelessFormatter(targetType);

            formatter.Serialize(ref writer, target, Resolver);

            return writer.ToUtf8ByteArray();
        }

        public override object Deserialize(Type targetType, byte[] data)
        {
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));
            if (data == null) throw new ArgumentNullException(nameof(data));

            var reader = new JsonReader();
            IJsonFormatter<object> formatter = GetTypelessFormatter(targetType);

            return formatter.Deserialize(ref reader, Resolver);
        }

        private IJsonFormatter<object> GetTypelessFormatter(Type targetType)
        {
            if (!UnionTypeProvider.TryGetUnionType(targetType, out Type unionType))
            {
                throw new ArgumentException($"The union type for the specified target type not found: '{targetType}'.", nameof(targetType));
            }

            if (!(Resolver.TryGetFormatter(unionType, out IJsonFormatter value) && value is IJsonFormatter<object> formatter))
            {
                throw new ArgumentException($"The formatter for the specified union type not found: '{unionType}'.", nameof(unionType));
            }

            return formatter;
        }
    }
}
