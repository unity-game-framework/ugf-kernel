using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.TestTools;

namespace Workspace.Runtime.Tests
{
    public class TestAddressableBuiltAssets
    {
        [UnityTest]
        public IEnumerator LoadMaterial1()
        {
            AsyncOperationHandle<Material> operation = Addressables.LoadAssetAsync<Material>("test_materials/test_material_1.mat");

            yield return operation;

            Assert.AreEqual(AsyncOperationStatus.Succeeded, operation.Status);
            Assert.NotNull(operation.Result);
            Assert.AreEqual("test_material_1", operation.Result.name);

            Addressables.Release(operation);
        }

        [UnityTest]
        public IEnumerator LoadMaterial2()
        {
            AsyncOperationHandle<Material> operation = Addressables.LoadAssetAsync<Material>("test_materials/test_material_2.mat");

            yield return operation;

            Assert.AreEqual(AsyncOperationStatus.Succeeded, operation.Status);
            Assert.NotNull(operation.Result);
            Assert.AreEqual("test_material_2", operation.Result.name);

            Addressables.Release(operation);
        }

        [UnityTest]
        public IEnumerator LoadMaterial3()
        {
            AsyncOperationHandle<Material> operation = Addressables.LoadAssetAsync<Material>("test_material_3");

            yield return operation;

            Assert.AreEqual(AsyncOperationStatus.Succeeded, operation.Status);
            Assert.NotNull(operation.Result);
            Assert.AreEqual("test_material_3", operation.Result.name);

            Addressables.Release(operation);
        }
    }
}
