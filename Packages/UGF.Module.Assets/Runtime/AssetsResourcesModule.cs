using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Module.Assets.Runtime.Coroutines;
using UGF.Module.Coroutines.Runtime;
using UnityEngine;

namespace UGF.Module.Assets.Runtime
{
    public class AssetsResourcesModule : ApplicationModuleBase, IAssetsModule
    {
        public ICoroutineModule CoroutineModule { get; }

        public AssetsResourcesModule(ICoroutineModule coroutineModule)
        {
            CoroutineModule = coroutineModule ?? throw new ArgumentNullException(nameof(coroutineModule));
        }

        public ICoroutine<T> LoadAsync<T>(string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            ResourceRequest request = Resources.LoadAsync(key, typeof(T));
            var coroutine = new ResourceRequestCoroutine<T>(request);

            CoroutineModule.Start(coroutine);

            return coroutine;
        }

        public ICoroutine<object> LoadAsync(string key, Type assetType)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            ResourceRequest request = Resources.LoadAsync(key, assetType);
            var coroutine = new ResourceRequestCoroutine<object>(request);

            CoroutineModule.Start(coroutine);

            return null;
        }

        public ICoroutine<IReadOnlyList<T>> LoadAllAsync<T>(string key)
        {
            throw new NotSupportedException("Async loading collection of assets from the Resources not supported.");
        }

        public ICoroutine<IReadOnlyList<object>> LoadAllAsync(string key, Type assetType)
        {
            throw new NotSupportedException("Async loading collection of assets from the Resources not supported.");
        }

        public void Release<T>(T asset)
        {
        }

        public void Release(object asset)
        {
            if (asset == null) throw new ArgumentNullException(nameof(asset));
        }
    }
}
