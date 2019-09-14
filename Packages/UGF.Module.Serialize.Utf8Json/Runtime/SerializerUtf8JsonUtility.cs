using UGF.Serialize.Runtime;

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
    }
}
