using UGF.Application.Runtime;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModuleBase, ISerializeModule
    {
        public ISerializerProvider Provider { get; } = new SerializerProvider();
    }
}
