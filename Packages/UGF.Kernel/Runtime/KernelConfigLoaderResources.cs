using System;
using System.Collections;
using UGF.Description.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelConfigLoaderResources : IKernelConfigLoader
    {
        public IKernelConfig Result { get; private set; }

        public IEnumerator LoadAsync(string configId)
        {
            ResourceRequest operation = Resources.LoadAsync<DescriptionAsset>(configId);

            yield return operation;

            DescriptionAsset asset = operation.asset as DescriptionAsset ?? throw new ArgumentNullException(nameof(operation.asset));
            IKernelConfig config = asset.GetDescription<IKernelConfig>() ?? throw new ArgumentNullException(nameof(asset.GetDescription));

            Result = config;
        }

        public IKernelConfig GetResult()
        {
            return Result;
        }
    }
}
