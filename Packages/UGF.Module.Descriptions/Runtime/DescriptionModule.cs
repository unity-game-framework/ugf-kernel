using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Assets.Runtime;

namespace UGF.Module.Descriptions.Runtime
{
    public class DescriptionModule : ApplicationModuleBaseAsync, IDescriptionModule
    {
        public IDescriptionModuleDescription Description { get; }
        public IReadOnlyDictionary<string, IDescription> Descriptions { get; }
        public IAssetsModule AssetsModule { get; }

        private readonly Dictionary<string, IDescription> m_descriptions = new Dictionary<string, IDescription>();

        public DescriptionModule(IDescriptionModuleDescription description, IAssetsModule assetsModule)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Descriptions = new ReadOnlyDictionary<string, IDescription>(m_descriptions);
            AssetsModule = assetsModule ?? throw new ArgumentNullException(nameof(assetsModule));
        }

        protected override IEnumerator OnInitializeAsync()
        {
            IReadOnlyList<IDescriptionAssetInfo> assetInfos = Description.AssetInfos;

            for (int i = 0; i < assetInfos.Count; i++)
            {
                IDescriptionAssetInfo assetInfo = assetInfos[i];
                ICoroutine<IDescription> coroutine = AssetsModule.LoadAsync<IDescription>(assetInfo.AssetName);

                yield return coroutine;

                Add(assetInfo.RegisterName, coroutine.Result);
            }
        }

        public void Add(string name, IDescription description)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (description == null) throw new ArgumentNullException(nameof(description));
            if (m_descriptions.ContainsKey(name)) throw new ArgumentException($"A description with the specified name already registered: '{name}'.", nameof(name));

            m_descriptions.Add(name, description);
        }

        public void Remove(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            m_descriptions.Remove(name);
        }

        public T GetDescription<T>(string name) where T : IDescription
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            return (T)m_descriptions[name];
        }

        public bool TryGetDescription<T>(string name, out T description) where T : IDescription
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            if (m_descriptions.TryGetValue(name, out IDescription value) && value is T cast)
            {
                description = cast;
                return true;
            }

            description = default;
            return false;
        }
    }
}
