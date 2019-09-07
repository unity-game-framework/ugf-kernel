using System;

namespace UGF.CustomSettings.Runtime
{
    public class CustomSettingsProperty<TData, TValue> where TData : class, new()
    {
        public TValue Value
        {
            get
            {
                if (Getter == null)
                {
                    throw new InvalidOperationException($"{typeof(TData).Name}: settings property cannot be read.");
                }

                return Getter(Settings.Instance);
            }
            set
            {
                if (Setter == null)
                {
                    throw new InvalidOperationException($"{typeof(TData).Name}: settings property cannot be written.");
                }

                Setter(Settings.Instance, value);

                if (ForceSave)
                {
                    Settings.Save();
                }
            }
        }

        public CustomSettings<TData> Settings { get; }
        public Func<TData, TValue> Getter { get; set; }
        public Action<TData, TValue> Setter { get; set; }
        public bool ForceSave { get; set; } = true;
        public bool CanRead { get { return Getter != null; } }
        public bool CanWrite { get { return Setter != null; } }

        public CustomSettingsProperty(CustomSettings<TData> settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public static implicit operator TValue(CustomSettingsProperty<TData, TValue> property)
        {
            return property.Value;
        }
    }
}
