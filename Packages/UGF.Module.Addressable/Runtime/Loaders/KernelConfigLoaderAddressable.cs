using System;
using UGF.Coroutines.Runtime;
using UGF.Kernel.Runtime;
using UGF.Kernel.Runtime.Loaders;
using UGF.Module.Addressable.Runtime.Coroutines;

namespace UGF.Module.Addressable.Runtime.Loaders
{
    public class KernelConfigLoaderAddressable : KernelConfigLoader
    {
        public override ICoroutine<IKernelConfig> Load(string configId)
        {
            if (string.IsNullOrEmpty(configId)) throw new ArgumentException("Value cannot be null or empty.", nameof(configId));

            return new LoadConfigAddressableCoroutine(configId);
        }
    }
}
