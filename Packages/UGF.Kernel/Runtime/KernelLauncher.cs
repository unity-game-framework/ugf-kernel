using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configId = "Config";

        public string ConfigId { get { return m_configId; } set { m_configId = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } }
        public bool HasConfig { get { return m_config != null; } }

        private readonly List<IModuleBuild> m_builds = new List<IModuleBuild>();
        private IKernelConfig m_config;

        protected override IEnumerator PreloadResourcesAsync()
        {
            IKernelConfigLoader configLoader = GetConfigLoader();
            IModuleBuildLoader buildLoader = GetModuleBuildLoader();

            Log.Debug($"KernelConfigLoader:'{configLoader}', ModuleBuildLoader:'{buildLoader}'.");

            yield return configLoader.LoadAsync(m_configId);

            m_config = configLoader.GetResult();

            Log.Debug($"Config:'{m_config}', name:'{m_config.Name}', modules:'{m_config.Modules.Count}'.");

            yield return buildLoader.LoadAsync(m_builds, m_config.Modules);
        }

        protected override IApplication CreateApplication()
        {
            var builds = new List<IModuleBuild>(m_builds);
            IApplication application = new KernelApplication(builds, ProvideStaticInstance);

            Log.Debug($"Application: '{application}'.");

            return application;
        }

        protected override void OnStopped()
        {
            base.OnStopped();

            m_config = null;
            m_builds.Clear();
        }

        protected virtual IKernelConfigLoader GetConfigLoader()
        {
            return new KernelConfigLoaderResources();
        }

        protected virtual IModuleBuildLoader GetModuleBuildLoader()
        {
            return new ModuleBuildLoaderResources();
        }
    }
}
