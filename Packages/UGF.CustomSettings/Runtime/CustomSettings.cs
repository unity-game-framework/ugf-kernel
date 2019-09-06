using System;
using Object = UnityEngine.Object;

namespace UGF.CustomSettings.Runtime
{
    public abstract class CustomSettings<TData> where TData : class, new()
    {
        public virtual TData Instance
        {
            get
            {
                if (m_instance == null || m_instance is Object target && target == null)
                {
                    m_instance = Load();
                }

                if (m_instance == null)
                {
                    throw new ArgumentException($"{typeof(TData).Name}: no settings data found.");
                }

                return m_instance;
            }
        }

        private TData m_instance;

        public void Save()
        {
            if (CanSave())
            {
                Save(m_instance);
            }
        }

        protected virtual bool CanSave()
        {
            return true;
        }

        protected abstract void Save(TData instance);
        protected abstract TData Load();
    }
}
