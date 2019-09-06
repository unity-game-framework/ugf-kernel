using UnityEngine;
using Object = UnityEngine.Object;

namespace UGF.CustomSettings.Runtime
{
    public abstract class CustomSettingsPlayMode<TData> : CustomSettings<TData> where TData : class, new()
    {
        public override TData Instance
        {
            get
            {
#if UNITY_EDITOR
                if (Application.isPlaying)
                {
                    return m_instance != null ? m_instance : m_instance = Copy(base.Instance);
                }

                if (m_instance != null)
                {
                    if (m_instance is Object target)
                    {
                        Object.DestroyImmediate(target);
                    }

                    m_instance = null;
                }
#endif

                return base.Instance;
            }
        }

        protected override bool CanSave()
        {
            return !Application.isPlaying;
        }

#if UNITY_EDITOR
        private TData m_instance;

        private static TData Copy(TData instance)
        {
            if (instance is Object target)
            {
                Object data = Object.Instantiate(target);

                data.hideFlags = HideFlags.HideAndDontSave;

                return (TData)(object)data;
            }

            return JsonUtility.FromJson<TData>(JsonUtility.ToJson(instance));
        }
#endif
    }
}
