using System.Collections;
using NUnit.Framework;
using UGF.Application.Runtime;
using UGF.Kernel.Runtime.Config;
using UGF.Testing.Runtime.Tests;
using UnityEngine.TestTools;

namespace UGF.Kernel.Runtime.Tests
{
    public class TestKernelLauncher : TestNoLogs
    {
        private class KernelResources : KernelLauncher
        {
            protected override IApplication CreateApplication()
            {
                return new KernelApplication();
            }
        }

        private class KernelJson : KernelLauncher
        {
            protected override IKernelConfigLoader GetConfigLoader()
            {
                return new KernelConfigJsonLoader(ConfigPath);
            }

            protected override IApplication CreateApplication()
            {
                return new KernelApplication();
            }
        }

        [UnityTest]
        public IEnumerator ConfigResources()
        {
            using (var scope = new TestComponentScope<KernelResources>())
            {
                KernelResources launcher = scope.Component;

                launcher.LaunchOnStart = false;
                launcher.ConfigPath = "Config";

                yield return launcher.Launch();

                Assert.NotNull(launcher.Config);
                Assert.AreEqual("DefaultAsset", launcher.Config.Name);
            }
        }

        [UnityTest]
        public IEnumerator ConfigJson()
        {
            using (var scope = new TestComponentScope<KernelJson>())
            {
                KernelJson launcher = scope.Component;

                launcher.LaunchOnStart = false;
                launcher.ConfigPath = $"{UnityEngine.Application.streamingAssetsPath}/Config.jsonc";

                yield return launcher.Launch();

                Assert.NotNull(launcher.Config);
                Assert.AreEqual("DefaultJson", launcher.Config.Name);
            }
        }
    }
}
