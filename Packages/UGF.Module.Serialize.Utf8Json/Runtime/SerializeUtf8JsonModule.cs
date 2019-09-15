using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Serialize.Runtime;
using UGF.Module.Serialize.Utf8Json.Runtime.Resolvers;
using UGF.Utf8Json.Runtime;
using Utf8Json;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializeUtf8JsonModule : ApplicationModuleBase, ISerializeUtf8JsonModule
    {
        public IApplication Application { get; }
        public IJsonFormatterResolver Resolver { get { return m_resolver; } }
        public IDictionary<Type, IJsonFormatter> Formatters { get { return m_resolver.Formatters; } }
        public IList<IJsonFormatterResolver> Resolvers { get { return m_resolver.Resolvers; } }
        public string SerializeBytesName { get; } = SerializerUtf8JsonUtility.SerializerBytesName;
        public string SerializerTextCompactName { get; } = SerializerUtf8JsonUtility.SerializerTextCompactName;
        public string SerializerTextReadableName { get; } = SerializerUtf8JsonUtility.SerializerTextReadableName;

        private readonly Utf8JsonFormatterResolver m_resolver = Utf8JsonUtility.CreateDefaultResolver();

        public SerializeUtf8JsonModule(IApplication application)
        {
            Application = application ?? throw new ArgumentNullException(nameof(application));

            m_resolver.Resolvers.Add(UGFModuleSerializeUtf8JsonRuntimeResolver.Instance);
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            var serializeModule = Application.GetModule<ISerializeModule>();

            serializeModule.Provider.Add(SerializeBytesName, new SerializerUtf8JsonBytes(Resolver));
            serializeModule.Provider.Add(SerializerTextCompactName, new SerializerUtf8Json(Resolver, false));
            serializeModule.Provider.Add(SerializerTextReadableName, new SerializerUtf8Json(Resolver, true));

            Log.Debug($"SerializeUtf8JsonModule: register '3' serializers (DataTypesCount:'{serializeModule.Provider.DataTypesCount}'): '{SerializeBytesName}', '{SerializerTextCompactName}', '{SerializerTextReadableName}'.");
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            var serializeModule = Application.GetModule<ISerializeModule>();

            serializeModule.Provider.Remove<byte[]>(SerializeBytesName);
            serializeModule.Provider.Remove<string>(SerializerTextCompactName);
            serializeModule.Provider.Remove<string>(SerializerTextReadableName);
        }
    }
}
