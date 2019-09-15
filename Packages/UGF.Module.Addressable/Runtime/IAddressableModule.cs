using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UGF.Module.Addressable.Runtime
{
    public interface IAddressableModule : IApplicationModule
    {
        /// <summary>
        /// Additively load catalogs from runtime data.  The settings are not used.
        /// </summary>
        /// <param name="catalogPath">The path to the runtime data.</param>
        /// <param name="providerSuffix">This value, if not null or empty, will be appended to all provider ids loaded from this data.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix);

        /// <summary>
        /// Load a single asset
        /// </summary>
        /// <param name="location">The location of the asset.</param>
        AsyncOperationHandle<T> LoadAssetAsync<T>(IResourceLocation location);

        /// <summary>
        /// Load a single asset
        /// </summary>
        /// <param name="key">The key of the location of the asset.</param>
        AsyncOperationHandle<T> LoadAssetAsync<T>(object key);

        /// <summary>
        /// Loads the resource locations specified by the keys.
        /// The method will always return success, with a valid IList of results. If nothing matches keys, IList will be empty
        /// </summary>
        /// <param name="keys">The set of keys to use.</param>
        /// <param name="mode">The mode for merging the results of the found locations.</param>
        /// <param name="type"></param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type);

        /// <summary>
        /// Request the locations for a given key.
        /// The method will always return success, with a valid IList of results. If nothing matches key, IList will be empty
        /// </summary>
        /// <param name="key">The key for the locations.</param>
        /// <param name="type"></param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type);

        /// <summary>
        /// Load multiple assets
        /// </summary>
        /// <param name="locations">The locations of the assets.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<IList<T>> LoadAssetsAsync<T>(IList<IResourceLocation> locations);

        /// <summary>
        /// Load multiple assets
        /// </summary>
        /// <param name="keys">List of keys for the locations.</param>
        /// <param name="mode">Method for merging the results of key matches.  See <see cref="Addressables.MergeMode"/> for specifics</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<IList<T>> LoadAssetsAsync<T>(IList<object> keys, Addressables.MergeMode mode);

        /// <summary>
        /// Load multiple assets
        /// </summary>
        /// <param name="key">Key for the locations.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<IList<T>> LoadAssetsAsync<T>(object key);

        /// <summary>
        /// Release asset.
        /// </summary>
        /// <typeparam name="T">The type of the object being released</typeparam>
        /// <param name="asset">The asset to release.</param>
        void Release<T>(T asset);

        /// <summary>
        /// Release the operation and its associated resources.
        /// </summary>
        /// <typeparam name="T">The type of the AsyncOperationHandle being released</typeparam>
        /// <param name="handle">The operation handle to release.</param>
        void Release<T>(AsyncOperationHandle<T> handle);

        /// <summary>
        /// Release the operation and its associated resources.
        /// </summary>
        /// <param name="handle">The operation handle to release.</param>
        void Release(AsyncOperationHandle handle);

        /// <summary>
        /// Determines the required download size, dependencies included, for the specified <paramref name="key"/>.
        /// Cached assets require no download and thus their download size will be 0.  The Result of the operation
        /// is the download size in bytes.
        /// </summary>
        /// <returns>The operation handle for the request.</returns>
        /// <param name="key">The key of the asset(s) to get the download size of.</param>
        AsyncOperationHandle<long> GetDownloadSizeAsync(object key);

        /// <summary>
        /// Determines the required download size, dependencies included, for the specified <paramref name="keys"/>.
        /// Cached assets require no download and thus their download size will be 0.  The Result of the operation
        /// is the download size in bytes.
        /// </summary>
        /// <returns>The operation handle for the request.</returns>
        /// <param name="keys">The keys of the asset(s) to get the download size of.</param>
        AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys);

        /// <summary>
        /// Downloads dependencies of assets marked with the specified label or address.
        /// </summary>
        /// <param name="key">The key of the asset(s) to load dependencies for.</param>
        /// <param name="autoReleaseHandle">Automatically releases the handle on completion</param>
        /// <returns>The AsyncOperationHandle for the dependency load.</returns>
        AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle);

        /// <summary>
        /// Downloads dependencies of assets at given locations.
        /// </summary>
        /// <param name="locations">The locations of the assets.</param>
        /// <param name="autoReleaseHandle">Automatically releases the handle on completion</param>
        /// <returns>The AsyncOperationHandle for the dependency load.</returns>
        AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle);

        /// <summary>
        /// Downloads dependencies of assets marked with the specified labels or addresses.
        /// </summary>
        /// <param name="keys">List of keys for the locations.</param>
        /// <param name="mode">Method for merging the results of key matches.  See <see cref="Addressables.MergeMode"/> for specifics</param>
        /// <param name="autoReleaseHandle">Automatically releases the handle on completion</param>
        /// <returns>The AsyncOperationHandle for the dependency load.</returns>
        AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle);

        /// <summary>
        /// Load scene.
        /// </summary>
        /// <param name="key">The key of the location of the scene to load.</param>
        /// <param name="loadMode">Scene load mode.</param>
        /// <param name="activateOnLoad">If false, the scene will load but not activate (for background loading).  The SceneInstance returned has an Activate() method that can be called to do this at a later point.</param>
        /// <param name="priority">Async operation priority for scene loading.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode, bool activateOnLoad, int priority);

        /// <summary>
        /// Load scene.
        /// </summary>
        /// <param name="location">The location of the scene to load.</param>
        /// <param name="loadMode">Scene load mode.</param>
        /// <param name="activateOnLoad">If false, the scene will load but not activate (for background loading).  The SceneInstance returned has an Activate() method that can be called to do this at a later point.</param>
        /// <param name="priority">Async operation priority for scene loading.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority);

        /// <summary>
        /// Release scene
        /// </summary>
        /// <param name="scene">The SceneInstance to release.</param>
        /// <param name="autoReleaseHandle">If true, the handle will be released automatically when complete.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle);

        /// <summary>
        /// Release scene
        /// </summary>
        /// <param name="handle">The handle returned by LoadSceneAsync for the scene to release.</param>
        /// <param name="autoReleaseHandle">If true, the handle will be released automatically when complete.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle);

        /// <summary>
        /// Release scene
        /// </summary>
        /// <param name="handle">The handle returned by LoadSceneAsync for the scene to release.</param>
        /// <param name="autoReleaseHandle">If true, the handle will be released automatically when complete.</param>
        /// <returns>The operation handle for the request.</returns>
        AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle);
    }
}
