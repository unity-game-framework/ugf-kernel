using System;
using System.Collections;
using UGF.Application.Runtime;
using UGF.Kernel.Runtime.Config;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configPath = "config";

        public string ConfigPath { get { return m_configPath; } set { m_configPath = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } }

        private IKernelConfig m_config;

        protected virtual IKernelConfigLoader GetConfigLoader()
        {
            return new KernelConfigAssetLoader(m_configPath);
        }

        protected override IEnumerator PreloadResourcesAsync()
        {
            IKernelConfigLoader loader = GetConfigLoader();

            yield return loader.Load();

            m_config = loader.GetResult() ?? throw new ArgumentException("The result of loading config is null.");
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = base.CreateApplication();

            return application;
        }
    }
}
