using UGF.Description.Runtime;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public interface ISerializeUtf8JsonModuleDescription : IDescription
    {
        string BytesSerializerName { get; }
        string TextCompactSerializerName { get; }
        string TextReadableSerializerName { get; }
    }
}
