using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configPath = "Config";

        public string ConfigPath { get { return m_configPath; } set { m_configPath = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } }
        public IReadOnlyList<IKernelModuleDescription> ModuleDescriptions { get; }

        private readonly List<IKernelModuleDescription> m_modules = new List<IKernelModuleDescription>();
        private IKernelConfig m_config;

        public KernelLauncher()
        {
            ModuleDescriptions = new ReadOnlyCollection<IKernelModuleDescription>(m_modules);
        }

        protected override IEnumerator PreloadResourcesAsync()
        {
            AsyncOperationHandle<IResourceLocator> initializeOperation = Addressables.InitializeAsync();

            while (!initializeOperation.IsDone)
            {
                yield return null;
            }

            AsyncOperationHandle<DescriptionAsset> configOperation = Addressables.LoadAssetAsync<DescriptionAsset>(m_configPath);

            while (!configOperation.IsDone)
            {
                yield return null;
            }

            m_config = configOperation.Result.GetDescription<IKernelConfig>();

            Addressables.Release(configOperation);

            foreach (IKernelConfigModule module in m_config.Modules)
            {
                AsyncOperationHandle<DescriptionAsset> moduleOperation = Addressables.LoadAssetAsync<DescriptionAsset>(module.AssetPath);

                while (!moduleOperation.IsDone)
                {
                    yield return null;
                }

                var moduleDescription = moduleOperation.Result.GetDescription<IKernelModuleDescription>();

                m_modules.Add(moduleDescription);

                Addressables.Release(moduleOperation);
            }
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
    }
}
