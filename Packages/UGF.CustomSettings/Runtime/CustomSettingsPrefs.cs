using UnityEngine;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsPrefs<TData> : CustomSettingsPlayMode<TData> where TData : class, new()
    {
        public string PrefsKey { get; }
        public bool ForceSave { get; }

        public CustomSettingsPrefs(string prefsKey, bool forceSave = false)
        {
            PrefsKey = prefsKey;
            ForceSave = forceSave;
        }

        protected override void Save(TData instance)
        {
            string data = JsonUtility.ToJson(instance);

            PlayerPrefs.SetString(PrefsKey, data);

            if (ForceSave)
            {
                PlayerPrefs.Save();
            }
        }

        protected override TData Load()
        {
            string data = PlayerPrefs.GetString(PrefsKey, "{}");

            return JsonUtility.FromJson<TData>(data);
        }
    }
}
