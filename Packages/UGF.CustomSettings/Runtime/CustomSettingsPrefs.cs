using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsPrefs<TData> : CustomSettingsPlayMode<TData> where TData : class, new()
    {
        public string Key { get; }
        public bool ForceSave { get; }

        public CustomSettingsPrefs(string key, bool forceSave = false)
        {
            Key = key;
            ForceSave = forceSave;
        }

        protected override void Save(TData instance)
        {
            string data = JsonUtility.ToJson(instance);

            PlayerPrefs.SetString(Key, data);

            if (ForceSave)
            {
                PlayerPrefs.Save();
            }
        }

        protected override TData Load()
        {
            string data = PlayerPrefs.GetString(Key, "{}");

            return JsonUtility.FromJson<TData>(data);
        }
    }
}
