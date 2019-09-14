using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public IReadOnlyList<ModuleBuild> Builds { get; }

        private readonly List<ModuleBuild> m_builds = new List<ModuleBuild>();
        private IKernelConfig m_config;

        public KernelLauncher()
        {
            Builds = new ReadOnlyCollection<ModuleBuild>(m_builds);
        }

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

            IReadOnlyList<ModuleBuildInfo> modules = GetModuleBuildInfos(m_config);

            yield return buildLoader.LoadAsync(m_builds, modules);

            Log.Debug($"Module builds:'{m_builds.Count}'.");
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = new KernelApplication(ProvideStaticInstance);

            Log.Debug($"Create application:'{application}'.");

            CreateModules(application, Builds);

            return application;
        }

        protected virtual void CreateModules(IApplication application, IReadOnlyList<ModuleBuild> builds)
        {
            Log.Debug(nameof(CreateModules));

            for (int i = 0; i < builds.Count; i++)
            {
                ModuleBuild build = builds[i];
                IModuleBuilder builder = build.Builder;
                Type registerType = builder.RegisterType;
                IApplicationModule module = build.HasDescription ? builder.Build(application, build.Description) : builder.Build(application);

                application.AddModule(registerType, module);

                Log.Debug($"Build Module: registerType:'{registerType}'.");
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

        protected virtual IReadOnlyList<ModuleBuildInfo> GetModuleBuildInfos(IKernelConfig config)
        {
            var infos = new List<ModuleBuildInfo>();

            for (int i = 0; i < config.Modules.Count; i++)
            {
                IKernelConfigModuleInfo module = config.Modules[i];
                var info = new ModuleBuildInfo(module.BuilderId, module.DescriptionId);

                infos.Add(info);
            }

            return infos;
        }
    }
}
