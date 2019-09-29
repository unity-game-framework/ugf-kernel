using System;
using UGF.Application.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Serialize.Runtime;
using UGF.Module.Serialize.Utf8Json.Runtime.Resolvers;
using UGF.Utf8Json.Runtime;
using UGF.Utf8Json.Runtime.Formatters.Union;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializeUtf8JsonModule : ApplicationModuleBase, ISerializeUtf8JsonModule
    {
        public IApplication Application { get; }
        public ISerializeModule SerializeModule { get; }
        public ISerializeUtf8JsonModuleDescription Description { get; }
        public IUtf8JsonFormatterResolver Resolver { get { return m_resolver; } }
        public ISerializeUtf8JsonUnionProvider UnionProvider { get { return m_unionProvider; } }

        private readonly Utf8JsonFormatterResolver m_resolver = Utf8JsonUtility.CreateDefaultResolver();
        private readonly UnionSerializer m_unionSerializer = new UnionSerializer();
        private readonly SerializeUtf8JsonUnionProvider m_unionProvider;

        public SerializeUtf8JsonModule(IApplication application, ISerializeModule serializeModule, ISerializeUtf8JsonModuleDescription description)
        {
            Application = application ?? throw new ArgumentNullException(nameof(application));
            SerializeModule = serializeModule ?? throw new ArgumentNullException(nameof(serializeModule));
            Description = description ?? throw new ArgumentNullException(nameof(description));

            m_resolver.AddResolver(UGFModuleSerializeUtf8JsonRuntimeResolver.Instance);
            m_unionProvider = new SerializeUtf8JsonUnionProvider(m_resolver, m_unionSerializer);
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            string bytesName = Description.BytesSerializerName;
            string compactName = Description.TextCompactSerializerName;
            string readableName = Description.TextReadableSerializerName;

            var bytes = new SerializerUtf8JsonBytes(m_resolver, m_unionProvider);
            var compact = new SerializerUtf8Json(m_resolver, m_unionProvider, false);
            var readable = new SerializerUtf8Json(m_resolver, m_unionProvider, true);

            SerializeModule.Provider.Add(bytesName, bytes);
            SerializeModule.Provider.Add(compactName, compact);
            SerializeModule.Provider.Add(readableName, readable);

            Log.Debug($"SerializeUtf8JsonModule: register '3' serializers: '{bytesName}', '{readable}', '{compact}'.");
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            SerializeModule.Provider.Remove<byte[]>(Description.BytesSerializerName);
            SerializeModule.Provider.Remove<string>(Description.TextCompactSerializerName);
            SerializeModule.Provider.Remove<string>(Description.TextReadableSerializerName);
        }
    }
}
