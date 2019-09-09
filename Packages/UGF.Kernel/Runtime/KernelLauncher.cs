using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Application.Runtime;
using UGF.Kernel.Runtime.Description;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configPath = "Config";

        public string ConfigPath { get { return m_configPath; } set { m_configPath = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } }
        public IReadOnlyList<IKernelModuleDescription> ModuleDescriptions { get; }

        private IKernelConfig m_config;
        private List<IKernelModuleDescription> m_modules = new List<IKernelModuleDescription>();

        public KernelLauncher()
        {
            ModuleDescriptions = new ReadOnlyCollection<IKernelModuleDescription>(m_modules);
        }

        protected virtual IDescriptionLoader GetConfigLoader()
        {
            return new DescriptionLoaderResources<IKernelConfig>(m_configPath);
        }

        protected virtual IDescriptionLoader GetConfigModuleLoader(IKernelConfigModule module)
        {
            return new DescriptionLoaderResources<IKernelModuleDescription>(module.AssetPath);
        }

        protected override IEnumerator PreloadResourcesAsync()
        {
            IDescriptionLoader loader = GetConfigLoader() ?? throw new ArgumentNullException(nameof(loader), "The config loader can not be null.");

            yield return loader.Load();

            m_config = loader.GetResult<IKernelConfig>();

            foreach (IKernelConfigModule module in m_config.Modules)
            {
                IDescriptionLoader moduleLoader = GetConfigModuleLoader(module);

                yield return moduleLoader.Load();

                var moduleDescription = moduleLoader.GetResult<IKernelModuleDescription>();

                m_modules.Add(moduleDescription);
            }

            IComparer<IKernelModuleDescription> comparer = GetKernelModuleDescriptionComparer();

            m_modules.Sort(comparer);
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = new KernelApplication(ProvideStaticInstance);

            CreateModules(application, ModuleDescriptions);

            return application;
        }

        protected virtual void CreateModules(IApplication application, IReadOnlyList<IKernelModuleDescription> modules)
        {
            for (int i = 0; i < modules.Count; i++)
            {
                IKernelModuleDescription module = modules[i];

                module.Initialize(application);
            }
        }

        protected override void OnStopped()
        {
            base.OnStopped();

            m_config = null;
            m_modules.Clear();
        }

        protected virtual IComparer<IKernelModuleDescription> GetKernelModuleDescriptionComparer()
        {
            return new KernelModuleDescriptionComparer();
        }
    }
}
