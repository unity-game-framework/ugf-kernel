using System.Collections;
using NUnit.Framework;
using UGF.Application.Runtime;
using UGF.Kernel.Runtime.Config;
using UnityEngine;
using UnityEngine.TestTools;

namespace UGF.Kernel.Runtime.Tests
{
    public class TestKernelLauncher
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

        [SetUp]
        public void Setup()
        {
            Debug.unityLogger.logEnabled = false;
        }

        [TearDown]
        public void TearDown()
        {
            Debug.unityLogger.logEnabled = true;
        }

        [UnityTest]
        public IEnumerator ConfigResources()
        {
            var launcher = new GameObject("launcher").AddComponent<KernelResources>();

            launcher.LaunchOnStart = false;

            yield return launcher.Launch();

            Assert.NotNull(launcher.Config);
            Assert.AreEqual("default_asset", launcher.Config.Name);

            Object.DestroyImmediate(launcher.gameObject);
        }

        [UnityTest]
        public IEnumerator ConfigJson()
        {
            var launcher = new GameObject("launcher").AddComponent<KernelJson>();

            launcher.LaunchOnStart = false;
            launcher.ConfigPath = $"{UnityEngine.Application.streamingAssetsPath}/config.json";

            yield return launcher.Launch();

            Assert.NotNull(launcher.Config);
            Assert.AreEqual("default_json", launcher.Config.Name);

            Object.DestroyImmediate(launcher.gameObject);
        }
    }
}
