using System;
using UGF.Coroutines.Runtime;

namespace UGF.Module.Assets.Runtime.Sources
{
    public interface IAssetSource
    {
        T Load<T>(string assetName) where T : class;
        object Load(string assetName, Type assetType);
        ICoroutine<T> LoadAsync<T>(string assetName) where T : class;
        ICoroutine<object> LoadAsync(string assetName, Type assetType);
    }
}
