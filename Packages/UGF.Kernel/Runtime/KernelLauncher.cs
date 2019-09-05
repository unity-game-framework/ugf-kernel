using System;
using System.Collections;
using UGF.Application.Runtime;
using UGF.Kernel.Runtime.Config;
using UGF.Logs.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configPath = "config";
        [SerializeField] private KernelConfigLoaderType m_configLoaderType = KernelConfigLoaderType.Resources;

        public string ConfigPath { get { return m_configPath; } set { m_configPath = value; } }
        public KernelConfigLoaderType ConfigLoaderType { get { return m_configLoaderType; } set { m_configLoaderType = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } }

        private IKernelConfig m_config;

        protected virtual IKernelConfigLoader GetConfigLoader()
        {
            switch (m_configLoaderType)
            {
                case KernelConfigLoaderType.Resources: return new KernelConfigResourcesLoader(m_configPath);
                case KernelConfigLoaderType.Json: return new KernelConfigJsonLoader(m_configPath);
                default: throw new ArgumentOutOfRangeException(nameof(m_configLoaderType), $"Unknown config loader type: '{m_configLoaderType}'.");
            }
        }

        protected override IEnumerator PreloadResourcesAsync()
        {
            IKernelConfigLoader loader = GetConfigLoader();

            if (loader == null)
            {
                throw new ArgumentNullException(nameof(loader), "The config loader can not be null.");
            }

            Log.Debug($"Kernel: config loader '{loader}'.");

            yield return loader.Load();

            m_config = loader.GetResult() ?? throw new ArgumentException("The result of loading config is null.");

            Log.Debug($"Kernel: config loaded '{m_config.Name}'.");
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = base.CreateApplication();

            return application;
        }
    }
}
