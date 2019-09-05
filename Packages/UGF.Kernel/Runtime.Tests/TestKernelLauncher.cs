using System.Collections;
using NUnit.Framework;
using UGF.Kernel.Runtime.Config;
using UGF.Testing.Runtime.Tests;
using UnityEngine.TestTools;

namespace UGF.Kernel.Runtime.Tests
{
    public class TestKernelLauncher : TestNoLogs
    {
        [UnityTest]
        public IEnumerator ConfigResources()
        {
            using (var scope = new TestComponentScope<KernelLauncher>())
            {
                KernelLauncher launcher = scope.Component;

                launcher.LaunchOnStart = false;
                launcher.ConfigPath = "Config";
                launcher.ConfigLoaderType = KernelConfigLoaderType.Resources;

                yield return launcher.Launch();

                Assert.NotNull(launcher.Config);
                Assert.AreEqual("DefaultAsset", launcher.Config.Name);
            }
        }

        [UnityTest]
        public IEnumerator ConfigJson()
        {
            using (var scope = new TestComponentScope<KernelLauncher>())
            {
                KernelLauncher launcher = scope.Component;

                launcher.LaunchOnStart = false;
                launcher.ConfigPath = $"{UnityEngine.Application.streamingAssetsPath}/Config.jsonc";
                launcher.ConfigLoaderType = KernelConfigLoaderType.Json;

                yield return launcher.Launch();

                Assert.NotNull(launcher.Config);
                Assert.AreEqual("DefaultJson", launcher.Config.Name);
            }
        }
    }
}
