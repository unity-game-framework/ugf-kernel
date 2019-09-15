using UGF.Application.Runtime;
using UGF.Serialize.Runtime;
using UGF.Serialize.Runtime.Formatter;
using UGF.Serialize.Runtime.Unity;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModuleBase, ISerializeModule
    {
        public ISerializeModuleDescription Description { get; }
        public ISerializerProvider Provider { get; } = new SerializerProvider();

        public SerializeModule(ISerializeModuleDescription description)
        {
            Description = description;

            Provider.Add(SerializerFormatterUtility.SerializerBinaryName, SerializerFormatterUtility.SerializerBinary);
            Provider.Add(SerializerUnityJsonUtility.SerializerTextCompactName, SerializerUnityJsonUtility.SerializerTextCompact);
            Provider.Add(SerializerUnityJsonUtility.SerializerTextReadableName, SerializerUnityJsonUtility.SerializerTextReadable);
            Provider.Add(SerializerUnityJsonUtility.SerializerBytesName, SerializerUnityJsonUtility.SerializerBytes);
        }

        public ISerializer<byte[]> GetDefaultBytesSerializer()
        {
            return Provider.Get<byte[]>(Description.DefaultBytesSerializerName);
        }

        public ISerializer<string> GetDefaultTextSerializer()
        {
            return Provider.Get<string>(Description.DefaultTextSerializerName);
        }
    }
}
