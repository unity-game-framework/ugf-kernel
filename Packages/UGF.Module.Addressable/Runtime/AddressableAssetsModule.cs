using System;
using System.Collections;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Addressable.Runtime.Coroutines;
using UGF.Module.Assets.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UGF.Module.Addressable.Runtime
{
    public class AddressableAssetsModule : ApplicationModuleBaseAsync, IAssetsModule
    {
        protected override IEnumerator OnInitializeAsync()
        {
            AsyncOperationHandle<IResourceLocator> operation = Addressables.InitializeAsync();

            while (!operation.IsDone)
            {
                yield return null;
            }

            Log.Debug($"AddressableAssetsModule initialized: locators:'{Addressables.ResourceLocators.Count}', runtimePath:'{Addressables.RuntimePath}'.");
        }

        public ICoroutine<T> LoadAsync<T>(string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            AsyncOperationHandle<T> handler = Addressables.LoadAssetAsync<T>(key);

            return new OperationHandleCoroutine<T>(handler);
        }

        public ICoroutine<object> LoadAsync(string key, Type assetType)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            AsyncOperationHandle<object> handler = Addressables.LoadAssetAsync<object>(key);

            return new OperationHandleCoroutine<object>(handler);
        }

        public void Release<T>(T asset)
        {
            Addressables.Release(asset);
        }

        public void Release(object asset)
        {
            if (asset == null) throw new ArgumentNullException(nameof(asset));

            Addressables.Release(asset);
        }
    }
}
