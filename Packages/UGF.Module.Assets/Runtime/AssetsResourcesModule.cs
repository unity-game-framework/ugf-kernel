using System;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Module.Assets.Runtime.Coroutines;
using UnityEngine;

namespace UGF.Module.Assets.Runtime
{
    public class AssetsResourcesModule : ApplicationModuleBase, IAssetsModule
    {
        public ICoroutine<T> LoadAsync<T>(string assetName)
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

        public void Release<T>(T asset)
        {
        }

        public void Release(object asset)
        {
        }
    }
}
