using System;
using System.Threading.Tasks;
using UGF.Serialize.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    /// <summary>
    /// Provides utilities to work with Utf8Json serializer.
    /// </summary>
    public static class SerializerUtf8JsonUtility
    {
        /// <summary>
        /// Gets the default name of the Json compact text serializer used in <see cref="ISerializerProvider"/>.
        /// </summary>
        public static string SerializerTextCompactName { get; } = "utf8json-text-compact";

        /// <summary>
        /// Gets the default name of the Json readable text serializer used in <see cref="ISerializerProvider"/>.
        /// </summary>
        public static string SerializerTextReadableName { get; } = "utf8json-text-readable";

        /// <summary>
        /// Gets the default name of the Json byte array serializer used in <see cref="ISerializerProvider"/>.
        /// </summary>
        public static string SerializerBytesName { get; } = "utf8json-bytes";

        public static string SerializeToString<T>(T value, IJsonFormatterResolver resolver)
        {
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            return JsonSerializer.ToJsonString(value, resolver);
        }

        public static byte[] Serialize<T>(T value, IJsonFormatterResolver resolver)
        {
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            return JsonSerializer.Serialize(value, resolver);
        }

        public static async Task<byte[]> SerializeAsync<T>(T value, IJsonFormatterResolver resolver)
        {
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            return await Task.Run(() => JsonSerializer.Serialize(value, resolver));
        }

        public static T DeserializeFromString<T>(string data, IJsonFormatterResolver resolver)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            return JsonSerializer.Deserialize<T>(data, resolver);
        }

        public static T Deserialize<T>(byte[] data, IJsonFormatterResolver resolver)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            return JsonSerializer.Deserialize<T>(data, resolver);
        }

        public static async Task<T> DeserializeAsync<T>(byte[] data, IJsonFormatterResolver resolver)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            return await Task.Run(() => JsonSerializer.Deserialize<T>(data, resolver));
        }
    }
}
