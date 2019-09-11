using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Application.Runtime;
using UGF.Modules.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configId = "Config";

        public string ConfigId { get { return m_configId; } set { m_configId = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } }
        public bool HasConfig { get { return m_config != null; } }
        public IReadOnlyList<ModuleBuild> Builds { get; }

        private readonly List<ModuleBuild> m_builds = new List<ModuleBuild>();
        private IKernelConfig m_config;

        public KernelLauncher()
        {
            Builds = new ReadOnlyCollection<ModuleBuild>(m_builds);
        }

        protected override IEnumerator PreloadResourcesAsync()
        {
            IKernelConfigLoader configLoader = GetConfigLoader();
            IModuleBuildLoader buildLoader = GetModuleBuildLoader();

            yield return configLoader.LoadAsync(m_configId);

            m_config = configLoader.GetResult();

            yield return buildLoader.LoadAsync(m_builds, m_config.Modules);
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = new KernelApplication(ProvideStaticInstance);

            CreateModules(application, Builds);

            return application;
        }

        protected virtual void CreateModules(IApplication application, IReadOnlyList<ModuleBuild> builds)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                ModuleBuild build = builds[i];
                IModuleBuilder builder = build.Builder;
                IModuleDescription description = build.Description;

                builder.Build(application, description);
            }
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
