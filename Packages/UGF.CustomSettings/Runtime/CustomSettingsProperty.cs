using System;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsProperty<TData, TValue> where TData : class, new()
    {
        public TValue Value
        {
            get { return m_getter(m_instance.Instance); }
            set
            {
                m_setter(m_instance.Instance, value);
                m_instance.Save();
            }
        }

        private readonly CustomSettings<TData> m_instance;
        private readonly Func<TData, TValue> m_getter;
        private readonly Action<TData, TValue> m_setter;

        public CustomSettingsProperty(CustomSettings<TData> instance, Func<TData, TValue> getter, Action<TData, TValue> setter)
        {
            m_instance = instance;
            m_getter = getter;
            m_setter = setter;
        }

        public static implicit operator TValue(CustomSettingsProperty<TData, TValue> property)
        {
            return property.Value;
        }
    }
}
