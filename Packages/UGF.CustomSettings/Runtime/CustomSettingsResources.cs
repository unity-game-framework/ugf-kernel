using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsResources<TData> : CustomSettingsPlayMode<TData> where TData : ScriptableObject, new()
    {
        public string ResourcesPath { get; }

        public CustomSettingsResources(string resourcesPath)
        {
            ResourcesPath = resourcesPath;
        }

        protected override void Save(TData instance)
        {
        }

        protected override TData Load()
        {
            var data = Resources.Load<TData>(ResourcesPath);

            if (data == null)
            {
                Debug.LogWarning($"{typeof(TData).Name}: no settings data found at resources path: '{ResourcesPath}'.");

                data = ScriptableObject.CreateInstance<TData>();
            }

            return data;
        }
    }
}