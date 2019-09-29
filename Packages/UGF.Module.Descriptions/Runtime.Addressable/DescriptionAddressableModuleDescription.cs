using System.Collections.ObjectModel;
using UnityEngine;
using System;
using System.Collections.Generic;

namespace UGF.Module.Descriptions.Runtime.Addressable
{
    [Serializable]
    public class DescriptionAddressableModuleDescription : IDescriptionModuleDescription
    {
        [SerializeField] private List<DescriptionAddressableAssetInfo> m_assetInfos = new List<DescriptionAddressableAssetInfo>();

        public List<DescriptionAddressableAssetInfo> AssetInfos { get { return m_assetInfos; } }

        IReadOnlyList<IDescriptionAssetInfo> IDescriptionModuleDescription.AssetInfos { get { return m_assetInfosReadOnly; } }

        private readonly ReadOnlyCollection<DescriptionAddressableAssetInfo> m_assetInfosReadOnly;

        public DescriptionAddressableModuleDescription()
        {
            m_assetInfosReadOnly = new ReadOnlyCollection<DescriptionAddressableAssetInfo>(m_assetInfos);
        }
    }
}
