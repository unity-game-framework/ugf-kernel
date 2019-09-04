using System;
using System.Collections;
using UnityEngine;

namespace UGF.Kernel.Runtime.Config
{
    public class KernelConfigResourcesLoader : IKernelConfigLoader
    {
        public string Path { get; }

        private IKernelConfig m_result;

        public KernelConfigResourcesLoader(string path)
        {
            Path = path;
        }

        public IEnumerator Load()
        {
            ResourceRequest operation = Resources.LoadAsync<KernelConfigAsset>(Path);

            yield return operation;

            var asset = operation.asset as KernelConfigAsset;

            if (asset == null)
            {
                throw new ArgumentException($"There is null in result of loading config by the specified path: '{Path}'.");
            }

            m_result = asset.Config;
        }

        public IKernelConfig GetResult()
        {
            return m_result ?? throw new InvalidOperationException("The config not loaded.");
        }

        public override string ToString()
        {
            return $"KernelConfigResourcesLoader: path '{Path}'";
        }
    }
}
