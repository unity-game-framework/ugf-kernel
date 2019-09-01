using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UGF.Addressable.Runtime.Tests
{
    public class TestBuiltAssetsScene : MonoBehaviour
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
            Assert.AreEqual(2, operation.Result.Count);
#else
            Assert.AreEqual(0, operation.Result.Count);
#endif
        }
    }
}
