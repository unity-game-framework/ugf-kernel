using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public interface ISerializeUtf8JsonModule : IApplicationModule
    {
        ISerializeUtf8JsonModuleDescription Description { get; }
        IJsonFormatterResolver Resolver { get; }
        IDictionary<Type, IJsonFormatter> Formatters { get; }
        IList<IJsonFormatterResolver> Resolvers { get; }
    }
}
