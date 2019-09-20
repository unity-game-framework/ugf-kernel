using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Addressable.Runtime.Coroutines;
using UGF.Module.Assets.Runtime;
using UGF.Module.Coroutines.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UGF.Module.Addressable.Runtime
{
    public class AddressableAssetsModule : ApplicationModuleBaseAsync, IAssetsModule
    {
        public ICoroutineModule CoroutineModule { get; }

        public AddressableAssetsModule(ICoroutineModule coroutineModule)
        {
            CoroutineModule = coroutineModule ?? throw new ArgumentNullException(nameof(coroutineModule));
        }

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
            var coroutine = new OperationHandleCoroutine<T>(handler);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }

        public ICoroutine<object> LoadAsync(string key, Type assetType)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            AsyncOperationHandle<object> handler = Addressables.LoadAssetAsync<object>(key);
            var coroutine = new OperationHandleCoroutine<object>(handler);

            CoroutineModule.Start(coroutine);

            return null;
        }

        public ICoroutine<IReadOnlyList<T>> LoadAllAsync<T>(string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            AsyncOperationHandle<IList<T>> handler = Addressables.LoadAssetsAsync<T>(key, null);
            var coroutine = new OperationHandleListCoroutine<T>(handler);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }

        public ICoroutine<IReadOnlyList<object>> LoadAllAsync(string key, Type assetType)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            AsyncOperationHandle<IList<object>> handler = Addressables.LoadAssetsAsync<object>(key, null);
            var coroutine = new OperationHandleListCoroutine<object>(handler);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }

        public void Release<T>(T asset)
        {
            if (asset == null) throw new ArgumentNullException(nameof(asset));

            Addressables.Release(asset);
        }

        public void Release(object asset)
        {
            if (asset == null) throw new ArgumentNullException(nameof(asset));

            Addressables.Release(asset);
        }
    }
}
