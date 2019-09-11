using UGF.Application.Runtime;

namespace UGF.Module.Addressable.Runtime
{
    public interface IAddressableModule : IApplicationModule
    {
        IAddressableModuleDescription Description { get; }
    }
}
