using System;
using UGF.Coroutines.Runtime;
using UGF.Module.Assets.Runtime.Sources;

namespace UGF.Module.Assets.Runtime.Loader
{
    public interface IAssetLoader
    {
        T Load<T>(string assetName, IAssetSource source) where T : class;
        object Load(string assetName, Type assetType, IAssetSource source);
        ICoroutine<T> LoadAsync<T>(string assetName, IAssetSource source) where T : class;
        ICoroutine<object> LoadAsync(string assetName, Type assetType, IAssetSource source);
    }
}
