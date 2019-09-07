using UGF.CustomSettings.Runtime;
using UnityEditor;

namespace UGF.CustomSettings.Editor
{
    public class CustomSettingsEditorPrefs<TData> : CustomSettings<TData> where TData : class, new()
    {
        public string PrefsKey { get; }

        public CustomSettingsEditorPrefs(string prefsKey)
        {
            PrefsKey = prefsKey;
        }

        protected override void Save(TData instance)
        {
            string data = EditorJsonUtility.ToJson(instance);

            EditorPrefs.SetString(PrefsKey, data);
        }

        protected override TData Load()
        {
            string data = EditorPrefs.GetString(PrefsKey, "{}");
            var target = new TData();

            EditorJsonUtility.FromJsonOverwrite(data, target);

            return target;
        }
    }
}
