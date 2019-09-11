using UGF.Application.Runtime;

namespace UGF.Module.Addressable.Runtime
{
    public class AddressableModule : ApplicationModuleBaseAsync, IAddressableModule
    {
        public IAddressableModuleDescription Description { get; }

        public AddressableModule(IAddressableModuleDescription description)
        {
            Description = description;
        }
    }
}
