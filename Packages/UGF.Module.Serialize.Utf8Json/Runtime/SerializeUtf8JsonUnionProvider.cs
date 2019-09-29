using System;
using System.Collections;
using System.Collections.Generic;
using UGF.Utf8Json.Runtime;
using UGF.Utf8Json.Runtime.Formatters.Union;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializeUtf8JsonUnionProvider : ISerializeUtf8JsonUnionProvider, IEnumerable<Type>
    {
        public IReadOnlyCollection<Type> TargetTypes { get { return m_targetTypeToUnionType.Keys; } }
        public IUtf8JsonFormatterResolver Resolver { get; }
        public IUnionSerializer UnionSerializer { get; }

        private readonly Dictionary<Type, Type> m_targetTypeToUnionType = new Dictionary<Type, Type>();

        public SerializeUtf8JsonUnionProvider(IUtf8JsonFormatterResolver resolver, IUnionSerializer unionSerializer)
        {
            Resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
            UnionSerializer = unionSerializer ?? throw new ArgumentNullException(nameof(unionSerializer));
        }

        public void Add<TUnionType, TTargetType>(string typeIdentifier) where TTargetType : TUnionType
        {
            Type unionType = typeof(TUnionType);
            Type targetType = typeof(TTargetType);

            if (typeIdentifier == null) throw new ArgumentNullException(nameof(typeIdentifier));
            if (m_targetTypeToUnionType.ContainsKey(targetType)) throw new ArgumentException($"The specified target type already exists: '{targetType}'.", nameof(targetType));

            IUnionFormatter<TUnionType> unionFormatter;

            if (Resolver.TryGetFormatter(unionType, out IJsonFormatter value))
            {
                if (value is IUnionFormatter<TUnionType> cast)
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
                var formatter = new UnionFormatter<TUnionType>(UnionSerializer);

                unionFormatter = formatter;

                Resolver.AddFormatter(unionType, formatter);
            }

            unionFormatter.AddFormatter<TTargetType>(typeIdentifier);
            m_targetTypeToUnionType.Add(targetType, unionType);
        }

        public void Add(Type unionType, Type targetType, string typeIdentifier, IJsonFormatter formatter)
        {
            if (unionType == null) throw new ArgumentNullException(nameof(unionType));
            if (targetType == null) throw new ArgumentNullException(nameof(targetType));
            if (typeIdentifier == null) throw new ArgumentNullException(nameof(typeIdentifier));
            if (formatter == null) throw new ArgumentNullException(nameof(formatter));
            if (m_targetTypeToUnionType.ContainsKey(targetType)) throw new ArgumentException($"The specified target type already exists: '{targetType}'.", nameof(targetType));

            if (!(Resolver.TryGetFormatter(unionType, out IJsonFormatter value) && value is UnionFormatter unionFormatter))
            {
                throw new ArgumentException($"The union formatter for the specified union type not found: '{unionType}'.");
            }

            unionFormatter.AddFormatter(targetType, typeIdentifier, formatter);
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
