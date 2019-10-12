using System;
using System.Collections;
using UGF.Coroutines.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime.Loaders
{
    public class KernelConfigLoaderAsset : KernelConfigLoader
    {
        [SerializeField] private KernelConfigAsset m_config;

        public KernelConfigAsset Config { get { return m_config; } set { m_config = value; } }

        private class KernelConfigLoaderAssetCoroutine : Coroutine<IKernelConfig>
        {
            public IKernelConfig Config { get; }

            public KernelConfigLoaderAssetCoroutine(IKernelConfig config)
            {
                Config = config ?? throw new ArgumentNullException(nameof(config));
            }

            protected override IEnumerator Routine()
            {
                Result = Config;

                yield break;
            }
        }

        public override ICoroutine<IKernelConfig> Load()
        {
            return new KernelConfigLoaderAssetCoroutine(m_config.Description);
        }
    }
}
