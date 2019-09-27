using System;
using System.Collections.Generic;
using UGF.Coroutines.Runtime;

namespace UGF.Assets.Runtime
{
    public interface IAssetsProvider
    {
        IReadOnlyDictionary<string, IAssetsSource> Sources { get; }

        void AddSource(string name, IAssetsSource source);
        void RemoveSource(string name);
        void ClearSources();
        T Load<T>(string assetName);
        object Load(string assetName, Type assetType);
        ICoroutine<T> LoadAsync<T>(string assetName);
        ICoroutine<object> LoadAsync(string assetName, Type assetType);
        void Release<T>(T asset);
        void Release(object asset);
    }
}
