using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Runtime;

namespace UGF.Kernel.Runtime
{
    public class KernelApplication : ApplicationUnity
    {
        public IReadOnlyList<IModuleBuild> Builds { get; }

        public KernelApplication(IReadOnlyList<IModuleBuild> builds, bool provideStaticInstance = true) : base(provideStaticInstance)
        {
            Builds = builds ?? throw new ArgumentNullException(nameof(builds));
        }

        protected override void OnPreInitialize()
        {
            base.OnPreInitialize();

            CreateModules(Builds);
        }

        protected override void OnPostUninitialize()
        {
            base.OnPostUninitialize();

            ClearModules();
        }

        protected override void OnInitializeModules()
        {
            for (int i = 0; i < Builds.Count; i++)
            {
                IModuleBuild build = Builds[i];
                IApplicationModule module = Modules[build.Builder.RegisterType];

                module.Initialize();
            }

            if (Modules.Count != Builds.Count)
            {
                foreach (KeyValuePair<Type, IApplicationModule> pair in Modules)
                {
                    if (!pair.Value.IsInitialized)
                    {
                        pair.Value.Initialize();
                    }
                }
            }
        }

        protected override void OnUninitializeModules()
        {
            for (int i = Builds.Count - 1; i >= 0; i--)
            {
                IModuleBuild build = Builds[i];
                IApplicationModule module = Modules[build.Builder.RegisterType];

                module.Uninitialize();
            }

            if (Modules.Count != Builds.Count)
            {
                foreach (KeyValuePair<Type, IApplicationModule> pair in Modules)
                {
                    if (pair.Value.IsInitialized)
                    {
                        pair.Value.Uninitialize();
                    }
                }
            }
        }

        protected virtual void CreateModules(IReadOnlyList<IModuleBuild> builds)
        {
            Log.Debug($"Create modules: '{builds.Count}'");

            for (int i = 0; i < builds.Count; i++)
            {
                IModuleBuild build = builds[i];
                IModuleBuilder builder = build.Builder;
                IModuleBuildArguments<IDescription> arguments = build.Arguments;
                Type registerType = builder.RegisterType;
                IApplicationModule module = builder.Build(this, arguments);

                AddModule(registerType, module);

                Log.Debug($"Build Module: registerType:'{registerType}', module:'{module}'.");
            }
        }
    }
}
