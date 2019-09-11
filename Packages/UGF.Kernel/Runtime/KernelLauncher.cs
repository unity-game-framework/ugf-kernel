using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Kernel.Runtime.Modules;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public class KernelLauncher : ApplicationUnityLauncher
    {
        [SerializeField] private string m_configIdentifier = "Config";

        public string ConfigIdentifier { get { return m_configIdentifier; } set { m_configIdentifier = value; } }
        public IKernelConfig Config { get { return m_config ?? throw new InvalidOperationException("Config not loaded."); } set { m_config = value; } }
        public bool HasConfig { get { return m_config != null; } }
        public IEnumerable<ModuleBuild> Builds { get; }

        private readonly List<ModuleBuild> m_builds = new List<ModuleBuild>();
        private IKernelConfig m_config;

        public KernelLauncher()
        {
            Builds = new ReadOnlyCollection<ModuleBuild>(m_builds);
        }

        protected override IEnumerator PreloadResourcesAsync()
        {
            yield return LoadConfig(m_configIdentifier);
            yield return LoadModules(Config);
        }

        protected virtual IEnumerator LoadConfig(string configIdentifier)
        {
            ResourceRequest operation = Resources.LoadAsync<DescriptionAsset>(configIdentifier);

            yield return operation;

            DescriptionAsset asset = operation.asset as DescriptionAsset ?? throw new ArgumentNullException(nameof(operation.asset));
            IKernelConfig config = asset.GetDescription<IKernelConfig>() ?? throw new ArgumentNullException(nameof(asset.GetDescription));

            Config = config;
        }

        protected virtual IEnumerator LoadModules(IKernelConfig config)
        {
            foreach (IKernelModuleConfig module in config.Modules)
            {
                ResourceRequest operation = Resources.LoadAsync<ModuleBuilderAsset>(module.BuilderIdentifier);

                yield return operation;

                ModuleBuilderAsset builderAsset = operation.asset as ModuleBuilderAsset ?? throw new ArgumentNullException(nameof(operation.asset));
                IModuleBuilder builder = builderAsset.GetBuilder() ?? throw new ArgumentNullException(nameof(builderAsset.GetBuilder));

                operation = Resources.LoadAsync<DescriptionAsset>(module.DescriptionIdentifier);

                yield return operation;

                DescriptionAsset descriptionAsset = operation.asset as DescriptionAsset ?? throw new ArgumentNullException(nameof(operation.asset));
                IModuleDescription description = descriptionAsset.GetDescription<IModuleDescription>() ?? throw new ArgumentNullException(nameof(descriptionAsset.GetDescription));

                m_builds.Add(new ModuleBuild(builder, description));
            }
        }

        protected override IApplication CreateApplication()
        {
            IApplication application = new KernelApplication(ProvideStaticInstance);

            CreateModules(application, Builds);

            return application;
        }

        protected virtual void CreateModules(IApplication application, IEnumerable<ModuleBuild> builds)
        {
            foreach (ModuleBuild build in builds)
            {
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
    }
}
