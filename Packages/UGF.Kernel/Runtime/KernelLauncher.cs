using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Application.Runtime;
using UGF.Description.Runtime;
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

        private IKernelConfig m_config;
        private IReadOnlyList<IModuleBuild> m_builds;

        protected override IEnumerator PreloadResourcesAsync()
        {
            Log.Debug(nameof(PreloadResourcesAsync));

            IKernelConfigLoader configLoader = GetConfigLoader();
            IModuleBuildLoader buildLoader = GetModuleBuildLoader();

            Log.Debug($"KernelConfigLoader:'{configLoader}'.");
            Log.Debug($"ModuleBuildLoader:'{buildLoader}'.");

            yield return configLoader.LoadAsync(m_configId);

            m_config = configLoader.GetResult();

            Log.Debug($"Config:'{m_config}', name:'{m_config.Name}', modules:'{m_config.Modules.Count}'.");

            var builds = new List<IModuleBuild>();

            yield return buildLoader.LoadAsync(builds, m_config.Modules);

            m_builds = new ReadOnlyCollection<IModuleBuild>(builds);

            Log.Debug($"Module builds:'{builds.Count}'.");
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = new KernelApplication(ProvideStaticInstance);

            Log.Debug($"Create application:'{application}'.");

            CreateModules(application, m_builds);

            m_builds = null;

            return application;
        }

        protected virtual void CreateModules(IApplication application, IReadOnlyList<IModuleBuild> builds)
        {
            Log.Debug(nameof(CreateModules));

            for (int i = 0; i < builds.Count; i++)
            {
                IModuleBuild build = builds[i];
                IModuleBuilder builder = build.Builder;
                IModuleBuildArguments<IDescription> arguments = build.Arguments;
                Type registerType = builder.RegisterType;
                IApplicationModule module = builder.Build(application, arguments);

                application.AddModule(registerType, module);

                Log.Debug($"Build Module: registerType:'{registerType}'.");
            }
        }

        protected override void OnStopped()
        {
            base.OnStopped();

            m_config = null;
            m_builds = null;
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
