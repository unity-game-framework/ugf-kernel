using System;
using System.Collections;
using UGF.Coroutines.Runtime;
using UGF.Description.Runtime;
using UGF.Kernel.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UGF.Module.Addressable.Runtime.Coroutines
{
    public class LoadConfigAddressableCoroutine : Coroutine<IKernelConfig>
    {
        public string ConfigId { get; }

        public LoadConfigAddressableCoroutine(string configId)
        {
            if (string.IsNullOrEmpty(configId)) throw new ArgumentException("Value cannot be null or empty.", nameof(configId));

            ConfigId = configId;
        }

        protected override IEnumerator Routine()
        {
            AsyncOperationHandle<DescriptionAsset> handle = Addressables.LoadAssetAsync<DescriptionAsset>(ConfigId);

            while (!handle.IsDone)
            {
                yield return null;
            }

            DescriptionAsset asset = handle.Result;
            var config = asset.GetDescription<IKernelConfig>();

            Result = config;

            Addressables.Release(handle);
        }
    }
}
