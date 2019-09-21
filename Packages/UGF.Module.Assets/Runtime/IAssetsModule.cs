using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;

namespace UGF.Module.Assets.Runtime
{
    public interface IAssetsModule : IApplicationModule
    {
        ICoroutine<T> LoadAsync<T>(string assetName);
        ICoroutine<object> LoadAsync(string assetName, Type assetType);
        ICoroutine<IReadOnlyList<T>> LoadAllAsync<T>(string assetName);
        ICoroutine<IReadOnlyList<object>> LoadAllAsync(string assetName, Type assetType);
        void Release<T>(T asset);
        void Release(object asset);
    }
}
