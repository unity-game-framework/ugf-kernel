using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Assertions;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace Workspace.Runtime.Addressable.TestBuildScript.Tests
{
    public class TestAddressableBuiltAssets : MonoBehaviour
    {
        private IEnumerator Start()
        {
            AsyncOperationHandle<IList<IResourceLocation>> operation = Addressables.LoadResourceLocationsAsync("test_materials/test_material_1.mat");
            AsyncOperationHandle<Material> operation2 = Addressables.LoadAssetAsync<Material>("test_material_3");

            yield return operation;
            yield return operation2;

            Assert.IsNotNull(operation.Result);
            Assert.IsNotNull(operation2.Result);

#if UNITY_EDITOR
            Assert.AreNotEqual(0, operation.Result.Count);
#else
            Assert.AreEqual(0, operation.Result.Count);
#endif
        }
    }
}
