namespace UGF.CustomSettings.Runtime
{
    public abstract class CustomSettings<TData> where TData : class, new()
    {
        public virtual TData Instance { get { return m_instance != null ? m_instance : m_instance = Load(); } }

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
