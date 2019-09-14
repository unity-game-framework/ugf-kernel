using UGF.Application.Runtime;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModule : IApplicationModule
    {
        ISerializerProvider Provider { get; }
    }
}
