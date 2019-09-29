using System;
using UGF.Coroutines.Runtime;
using UGF.Kernel.Runtime.Coroutines;

namespace UGF.Kernel.Runtime.Loaders
{
    public class KernelConfigLoaderResources : KernelConfigLoader
    {
        public override ICoroutine<IKernelConfig> Load(string configId)
        {
            if (string.IsNullOrEmpty(configId)) throw new ArgumentException("Value cannot be null or empty.", nameof(configId));

            return new LoadConfigResourcesCoroutine(configId);
        }
    }
}
