using UGF.Application.Runtime;
using UGF.Utf8Json.Runtime;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public interface ISerializeUtf8JsonModule : IApplicationModule
    {
        ISerializeUtf8JsonModuleDescription Description { get; }
        IUtf8JsonFormatterResolver Resolver { get; }
    }
}
