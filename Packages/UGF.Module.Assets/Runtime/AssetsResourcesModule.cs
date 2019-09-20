using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Coroutines.Runtime.Unity;
using UGF.Module.Assets.Runtime.Coroutines;
using UnityEngine;

namespace UGF.Module.Assets.Runtime
{
    public class AssetsResourcesModule : ApplicationModuleBase, IAssetsModule
    {
        public ICoroutineExecuter CoroutineExecuter
        {
            get
            {
                if (m_coroutineExecuter != null)
                {
                    return m_coroutineExecuter;
                }

                ValidateState(true);

                return m_executer;
            }
        }

        private readonly ICoroutineExecuter m_coroutineExecuter;
        private CoroutineExecuterUnity m_executer;

        public AssetsResourcesModule(ICoroutineExecuter coroutineExecuter = null)
        {
            m_coroutineExecuter = coroutineExecuter;
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            if (m_coroutineExecuter == null)
            {
                m_executer = new CoroutineExecuterUnity();
            }
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            if (m_executer != null)
            {
                m_executer.Dispose();
                m_executer = null;
            }
        }

        public ICoroutine<T> LoadAsync<T>(string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            ResourceRequest request = Resources.LoadAsync(key, typeof(T));
            var coroutine = new ResourceRequestCoroutine<T>(request);

            CoroutineExecuter.Start(coroutine);

            return coroutine;
        }

        public ICoroutine<object> LoadAsync(string key, Type assetType)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            ResourceRequest request = Resources.LoadAsync(key, assetType);
            var coroutine = new ResourceRequestCoroutine<object>(request);

            CoroutineExecuter.Start(coroutine);

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
