using UnityEngine.AddressableAssets;
using System;
using UnityEngine;

namespace UGF.Module.Descriptions.Runtime.Addressable
{
    [Serializable]
    public class DescriptionAddressableAssetInfo : IDescriptionAssetInfo
    {
        [SerializeField] private string m_registerName;
        [SerializeField] private AssetReference m_asset = new AssetReference();

        public string RegisterName { get { return m_registerName; } set { m_registerName = value; } }
        public AssetReference Asset { get { return m_asset; } set { m_asset = value; } }

        string IDescriptionAssetInfo.AssetName { get { return (string)m_asset.RuntimeKey; } }
    }
}
