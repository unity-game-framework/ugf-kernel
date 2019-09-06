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
                    if (m_instance == null || m_instance is Object target && target == null)
                    {
                        m_instance = Copy(base.Instance);
                    }

                    return m_instance;
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

#if UNITY_EDITOR
        private TData m_instance;
#endif

        protected override bool CanSave()
        {
            return !Application.isPlaying;
        }

#if UNITY_EDITOR
        private static TData Copy(TData instance)
        {
            if (instance is Object target)
            {
                Object data = Object.Instantiate(target);

                data.hideFlags = HideFlags.DontSave;

                return (TData)(object)data;
            }

            return JsonUtility.FromJson<TData>(JsonUtility.ToJson(instance));
        }
#endif
    }
}
