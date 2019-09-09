using System.Collections;
using UGF.Description.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime.Description
{
    public class DescriptionLoaderResources<TDescription> : DescriptionLoaderBase<TDescription> where TDescription : class, IDescription
    {
        public string ResourcesPath { get; }

        public DescriptionLoaderResources(string resourcesPath)
        {
            ResourcesPath = resourcesPath;
        }

        protected override IEnumerator OnLoad()
        {
            ResourceRequest operation = Resources.LoadAsync<DescriptionAssetBase>(ResourcesPath);

            yield return operation;

            if (operation.asset is DescriptionAsset<TDescription> asset)
            {
                Result = asset.Description;
            }
        }
    }
}
