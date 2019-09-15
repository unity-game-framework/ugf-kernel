using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelModuleInfoArguments : IModuleBuildArguments<string>
    {
        [SerializeField] private List<string> m_values = new List<string>();

        public List<string> Values { get { return m_values; } }

        public T Get<T>()
        {
            if (!TryGet(out T argument))
            {
                throw new ArgumentException($"The value of the specified type not found: '{typeof(T)}'.", nameof(T));
            }

            return argument;
        }

        public bool TryGet<T>(out T argument)
        {
            for (int i = 0; i < Values.Count; i++)
            {
                string value = Values[i];

                if (value is T cast)
                {
                    argument = cast;
                    return true;
                }
            }

            argument = default;
            return false;
        }

        public List<string>.Enumerator GetEnumerator()
        {
            return m_values.GetEnumerator();
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            return ((IEnumerable<string>)m_values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)m_values).GetEnumerator();
        }
    }
}
