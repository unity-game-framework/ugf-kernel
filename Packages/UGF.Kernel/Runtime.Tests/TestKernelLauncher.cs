using System.Collections;
using NUnit.Framework;
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

                yield return launcher.Launch();

                Assert.NotNull(launcher.Config);
                Assert.AreEqual("DefaultAsset", launcher.Config.Name);
            }
        }
    }
}
