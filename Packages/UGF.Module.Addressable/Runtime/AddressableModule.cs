using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Logs.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UGF.Module.Addressable.Runtime
{
    public class AddressableModule : ApplicationModuleBaseAsync, IAddressableModule
    {
        protected override IEnumerator OnInitializeAsync()
        {
            AsyncOperationHandle<IResourceLocator> operation = Addressables.InitializeAsync();

            while (!operation.IsDone)
            {
                yield return null;
            }

            Log.Debug($"Addressables initialized: locators:'{Addressables.ResourceLocators.Count}', runtimePath:'{Addressables.RuntimePath}'.");
        }

        public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix)
        {
            return Addressables.LoadContentCatalogAsync(catalogPath, providerSuffix);
        }

        public AsyncOperationHandle<T> LoadAssetAsync<T>(IResourceLocation location)
        {
            return Addressables.LoadAssetAsync<T>(location);
        }

        public AsyncOperationHandle<T> LoadAssetAsync<T>(object key)
        {
            return Addressables.LoadAssetAsync<T>(key);
        }

        public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type)
        {
            return Addressables.LoadResourceLocationsAsync(keys, mode, type);
        }

        public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type)
        {
            return Addressables.LoadResourceLocationsAsync(key, type);
        }

        public AsyncOperationHandle<IList<T>> LoadAssetsAsync<T>(IList<IResourceLocation> locations)
        {
            return Addressables.LoadAssetsAsync(locations, (Action<T>)null);
        }

        public AsyncOperationHandle<IList<T>> LoadAssetsAsync<T>(IList<object> keys, Addressables.MergeMode mode)
        {
            return Addressables.LoadAssetsAsync(keys, (Action<T>)null, mode);
        }

        public AsyncOperationHandle<IList<T>> LoadAssetsAsync<T>(object key)
        {
            return Addressables.LoadAssetsAsync(key, (Action<T>)null);
        }

        public void Release<T>(T asset)
        {
            Addressables.Release(asset);
        }

        public void Release<T>(AsyncOperationHandle<T> handle)
        {
            Addressables.Release(handle);
        }

        public void Release(AsyncOperationHandle handle)
        {
            Addressables.Release(handle);
        }

        public AsyncOperationHandle<long> GetDownloadSizeAsync(object key)
        {
            return Addressables.GetDownloadSizeAsync(key);
        }

        public AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys)
        {
            return Addressables.GetDownloadSizeAsync(keys);
        }

        public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle)
        {
            return Addressables.DownloadDependenciesAsync(key, autoReleaseHandle);
        }

        public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
        {
            return Addressables.DownloadDependenciesAsync(locations, autoReleaseHandle);
        }

        public AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle)
        {
            return Addressables.DownloadDependenciesAsync(keys, mode, autoReleaseHandle);
        }

        public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode, bool activateOnLoad, int priority)
        {
            return Addressables.LoadSceneAsync(key, loadMode, activateOnLoad, priority);
        }

        public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority)
        {
            return Addressables.LoadSceneAsync(location, loadMode, activateOnLoad, priority);
        }

        public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle)
        {
            return Addressables.UnloadSceneAsync(scene, autoReleaseHandle);
        }

        public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle)
        {
            return Addressables.UnloadSceneAsync(handle, autoReleaseHandle);
        }

        public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle)
        {
            return Addressables.UnloadSceneAsync(handle, autoReleaseHandle);
        }
    }
}
