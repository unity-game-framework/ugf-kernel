using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Kernel.Runtime.Loaders;
using UGF.Logs.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configId = "Config";
        [SerializeField] private KernelConfigLoader m_configLoader;
        [SerializeField] private KernelModuleBuildsLoader m_moduleBuildsLoader;

        public string ConfigId { get { return m_configId; } set { m_configId = value; } }

        public IKernelConfigLoader ConfigLoader
        {
            get
            {
                if (m_configLoader == null)
                {
                    throw new ArgumentNullException(nameof(m_configLoader), "The config loader not specified.");
                }

                return m_configLoader;
            }
            set { m_configLoader = (KernelConfigLoader)value; }
        }

        public IKernelModuleBuildsLoader ModuleBuildsLoader
        {
            get
            {
                if (m_moduleBuildsLoader == null)
                {
                    throw new ArgumentNullException(nameof(m_moduleBuildsLoader), "The module builds loader not specified.");
                }

                return m_moduleBuildsLoader;
            }
            set { m_moduleBuildsLoader = (KernelModuleBuildsLoader)value; }
        }

        public IKernelConfig Config
        {
            get
            {
                if (m_config == null)
                {
                    throw new InvalidOperationException("The Config not yet loaded.");
                }

                return m_config;
            }
        }

        public bool HasConfig { get { return m_config != null; } }

        private IKernelConfig m_config;
        private IReadOnlyList<IModuleBuild> m_builds;

        protected override IEnumerator PreloadResourcesAsync()
        {
            ICoroutine<IKernelConfig> configCoroutine = ConfigLoader.Load(m_configId);

            yield return configCoroutine;

            m_config = configCoroutine.Result;

            ICoroutine<IReadOnlyList<IModuleBuild>> moduleBuildsCoroutine = ModuleBuildsLoader.Load(m_config.Modules);

            yield return moduleBuildsCoroutine;

            m_builds = moduleBuildsCoroutine.Result;

            Log.Debug($"Config:'{m_config}', name:'{m_config.Name}', modules:'{m_config.Modules.Count}', builds:'{m_builds.Count}'.");
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = new KernelApplication(m_builds, ProvideStaticInstance);

            Log.Debug($"Application: '{application}'.");

            return application;
        }

        protected override void OnStopped()
        {
            base.OnStopped();

            m_config = null;
            m_builds = null;
        }
    }
}
