using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsResources<TData> : CustomSettingsPlayMode<TData> where TData : ScriptableObject, new()
    {
        public string Path { get; }

        public CustomSettingsResources(string path)
        {
            Path = path;
        }

        protected override void Save(TData instance)
        {
        }

        protected override TData Load()
        {
            var data = Resources.Load<TData>(Path);

            if (data == null)
            {
                Debug.LogWarning($"{typeof(TData).Name}: no settings data found at resources path: '{Path}'.");

                data = ScriptableObject.CreateInstance<TData>();
            }

            return data;
        }
    }
}
