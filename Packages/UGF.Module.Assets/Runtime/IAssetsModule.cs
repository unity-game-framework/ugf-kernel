using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;

namespace UGF.Module.Assets.Runtime
{
    public interface IAssetsModule : IApplicationModule
    {
        ICoroutine<T> LoadAsync<T>(string key);
        ICoroutine<object> LoadAsync(string key, Type assetType);
        ICoroutine<IReadOnlyList<T>> LoadAllAsync<T>(string key);
        ICoroutine<IReadOnlyList<object>> LoadAllAsync(string key, Type assetType);
        void Release<T>(T asset);
        void Release(object asset);
    }
}
