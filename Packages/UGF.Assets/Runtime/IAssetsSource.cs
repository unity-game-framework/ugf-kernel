using System;
using UGF.Coroutines.Runtime;

namespace UGF.Assets.Runtime
{
    public interface IAssetsSource
    {
        T Load<T>(IAssetInfo assetInfo);
        object Load(IAssetInfo assetInfo, Type assetType);
        ICoroutine<T> LoadAsync<T>(IAssetInfo assetInfo);
        ICoroutine<object> LoadAsync(IAssetInfo assetInfo, Type assetType);
        void Release<T>(T asset);
        void Release(object asset);
    }
}
