using System;
using UGF.Coroutines.Runtime;
using UGF.Module.Assets.Runtime.Coroutines;
using UnityEngine;

namespace UGF.Module.Assets.Runtime.Sources
{
    public class AssetSourceResources : IAssetSource
    {
        public T Load<T>(string assetName) where T : class
        {
            if (assetName == null) throw new ArgumentNullException(nameof(assetName));

            return (T)(object)Resources.Load(assetName, typeof(T));
        }

        public object Load(string assetName, Type assetType)
        {
            if (assetName == null) throw new ArgumentNullException(nameof(assetName));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            return Resources.Load(assetName, assetType);
        }

        public ICoroutine<T> LoadAsync<T>(string assetName) where T : class
        {
            if (assetName == null) throw new ArgumentNullException(nameof(assetName));

            ResourceRequest request = Resources.LoadAsync(assetName, typeof(T));

            return new ResourceRequestCoroutine<T>(request);
        }

        public ICoroutine<object> LoadAsync(string assetName, Type assetType)
        {
            if (assetName == null) throw new ArgumentNullException(nameof(assetName));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            ResourceRequest request = Resources.LoadAsync(assetName, assetType);

            return new ResourceRequestCoroutine<object>(request);
        }
    }
}
