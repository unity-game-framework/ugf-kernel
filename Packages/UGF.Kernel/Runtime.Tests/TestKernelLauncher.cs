using System.Collections;
using NUnit.Framework;
using UGF.Application.Runtime;
using UnityEngine;
using UnityEngine.TestTools;

namespace UGF.Kernel.Runtime.Tests
{
    public class TestKernelLauncher
    {
        private class KernelNoModules : KernelLauncher
        {
            protected override IApplication CreateApplication()
            {
                return new ApplicationUnity();
            }
        }

        [UnityTest]
        public IEnumerator Config()
        {
            var launcher = new GameObject("launcher").AddComponent<KernelNoModules>();

            launcher.enabled = false;

            yield return launcher.Launch();

            Assert.NotNull(launcher.Config);
            Assert.AreEqual("default", launcher.Config.Name);
        }
    }
}
