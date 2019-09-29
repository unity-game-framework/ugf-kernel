using System;
using System.Collections.Generic;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public interface ISerializeUtf8JsonUnionProvider
    {
        IReadOnlyCollection<Type> TargetTypes { get; }

        void Add<TUnionType, TTargetType>(string typeIdentifier) where TTargetType : TUnionType;
        void Add(Type unionType, Type targetType, string typeIdentifier, IJsonFormatter formatter);
        void Add(Type unionType, Type targetType);
        void Remove(Type unionType, Type targetType);
        Type GetUnionType(Type targetType);
        bool TryGetUnionType(Type targetType, out Type unionType);
    }
}
