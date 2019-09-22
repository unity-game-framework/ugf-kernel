using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Kernel.Runtime.Coroutines;
using UGF.Logs.Runtime;
using UGF.Module.Runtime;
using UGF.Module.Runtime.Coroutines;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configId = "Config";

        public string ConfigId { get { return m_configId; } set { m_configId = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } }
        public bool HasConfig { get { return m_config != null; } }

        private IKernelConfig m_config;
        private IReadOnlyList<IModuleBuild> m_builds;

        protected override IEnumerator PreloadResourcesAsync()
        {
            ICoroutine<IKernelConfig> loadConfigCoroutine = LoadConfig(m_configId);

            yield return loadConfigCoroutine;

            m_config = loadConfigCoroutine.Result;

            ICoroutine<IReadOnlyList<IModuleBuild>> loadModuleBuildsCoroutine = LoadModuleBuilds(m_config.Modules);

            yield return loadModuleBuildsCoroutine;

            m_builds = loadModuleBuildsCoroutine.Result;

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

        protected virtual ICoroutine<IKernelConfig> LoadConfig(string configId)
        {
            if (configId == null) throw new ArgumentNullException(nameof(configId));

            return new LoadConfigResourcesCoroutine(configId);
        }

        protected virtual ICoroutine<IReadOnlyList<IModuleBuild>> LoadModuleBuilds(IReadOnlyList<IModuleBuildInfo> infos)
        {
            if (infos == null) throw new ArgumentNullException(nameof(infos));

            return new LoadBuildsResourcesCoroutine(infos);
        }
    }
}
