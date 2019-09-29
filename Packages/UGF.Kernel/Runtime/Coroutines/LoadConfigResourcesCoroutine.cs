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

            var asset = (DescriptionAsset)operation.asset;

            if (asset == null)
            {
                throw new ArgumentNullException(nameof(asset), $"The result of loading asset is null: '{ConfigId}'.");
            }

            var config = asset.GetDescription<IKernelConfig>();

            Result = config;
        }
    }
}
