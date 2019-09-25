using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Utf8Json.Runtime;
using UGF.Utf8Json.Runtime.Formatters;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializeUtf8JsonUnionProvider : ISerializeUtf8JsonUnionProvider, IEnumerable<Type>
    {
        public IReadOnlyCollection<Type> TargetTypes { get { return m_targetTypeToUnionType.Keys; } }
        public IUtf8JsonFormatterResolver Resolver { get; }

        private readonly Dictionary<Type, Type> m_targetTypeToUnionType = new Dictionary<Type, Type>();

        public SerializeUtf8JsonUnionProvider(IUtf8JsonFormatterResolver resolver)
        {
            Resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
        }

        public void Add<TUnionType, TTargetType>(string typeIdentifier) where TTargetType : TUnionType
        {
            Type unionType = typeof(TUnionType);
            Type targetType = typeof(TTargetType);

            if (typeIdentifier == null) throw new ArgumentNullException(nameof(typeIdentifier));
            if (m_targetTypeToUnionType.ContainsKey(targetType)) throw new ArgumentException($"The specified target type already exists: '{targetType}'.", nameof(targetType));

            UnionFormatter<TUnionType> unionFormatter;

            if (Resolver.TryGetFormatter(unionType, out IJsonFormatter value))
            {
                if (value is UnionFormatter<TUnionType> cast)
                {
                    unionFormatter = cast;
                }
                else
                {
                    throw new ArgumentException($"The found formatter has unexpected union type: '{value}', unionType:'{unionType}'", nameof(targetType));
                }
            }
            else
            {
                unionFormatter = new UnionFormatter<TUnionType>();

                Resolver.AddFormatter(unionType, unionFormatter);
            }

            unionFormatter.AddFormatter<TTargetType>(typeIdentifier);
            m_targetTypeToUnionType.Add(targetType, unionType);
        }

        public void Add(Type unionType, string typeIdentifier, Type targetType, IJsonFormatter formatter)
        {
            if (unionType == null) throw new ArgumentNullException(nameof(unionType));
            if (typeIdentifier == null) throw new ArgumentNullException(nameof(typeIdentifier));
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));
            if (formatter == null) throw new ArgumentNullException(nameof(formatter));
            if (m_targetTypeToUnionType.ContainsKey(targetType)) throw new ArgumentException($"The specified target type already exists: '{targetType}'.", nameof(targetType));

            if (!(Resolver.TryGetFormatter(unionType, out IJsonFormatter value) && value is UnionFormatter unionFormatter))
            {
                throw new ArgumentException($"The union formatter for the specified union type not found: '{unionType}'.");
            }

            unionFormatter.AddFormatter(typeIdentifier, targetType, formatter);
            m_targetTypeToUnionType.Add(targetType, unionType);
        }

        public void Add(Type unionType, Type targetType)
        {
            if (unionType == null) throw new ArgumentNullException(nameof(unionType));
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));
            if (m_targetTypeToUnionType.ContainsKey(targetType)) throw new ArgumentException($"The specified target type already exists: '{targetType}'.", nameof(targetType));

            m_targetTypeToUnionType.Add(targetType, unionType);
        }

        public void Remove(Type unionType, Type targetType)
        {
            if (unionType == null) throw new ArgumentNullException(nameof(unionType));
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));

            if (m_targetTypeToUnionType.Remove(targetType) && Resolver.TryGetFormatter(unionType, out IJsonFormatter value) && value is UnionFormatter unionFormatter)
            {
                unionFormatter.RemoveFormatter(targetType);
            }
        }

        public Type GetUnionType(Type targetType)
        {
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));

            return m_targetTypeToUnionType[targetType];
        }

        public bool TryGetUnionType(Type targetType, out Type unionType)
        {
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));

            return m_targetTypeToUnionType.TryGetValue(targetType, out unionType);
        }

        public Dictionary<Type, Type>.KeyCollection GetEnumerator()
        {
            return m_targetTypeToUnionType.Keys;
        }

        IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
        {
            return ((IEnumerable<Type>)m_targetTypeToUnionType.Keys).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)m_targetTypeToUnionType.Keys).GetEnumerator();
        }
    }
}
