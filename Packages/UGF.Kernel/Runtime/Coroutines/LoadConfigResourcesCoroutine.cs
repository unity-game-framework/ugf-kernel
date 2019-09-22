using System;
using System.Collections;
using UGF.Coroutines.Runtime;
using UGF.Description.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime.Coroutines
{
    public class LoadConfigResourcesCoroutine : Coroutine<IKernelConfig>
    {
        public string ConfigId { get; }

        public LoadConfigResourcesCoroutine(string configId)
        {
            ConfigId = configId ?? throw new ArgumentNullException(nameof(configId));
        }

        protected override IEnumerator Routine()
        {
            ResourceRequest operation = Resources.LoadAsync<DescriptionAsset>(ConfigId);

            yield return operation;

            var asset = operation.asset as DescriptionAsset;

            if (asset == null)
            {
                throw new ArgumentNullException(nameof(operation.asset));
            }

            var config = asset.GetDescription<IKernelConfig>();

            if (config == null)
            {
                throw new ArgumentNullException(nameof(asset.GetDescription));
            }

            Result = config;
        }
    }
}
