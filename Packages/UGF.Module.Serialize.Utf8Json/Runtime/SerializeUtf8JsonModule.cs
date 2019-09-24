using System;
using UGF.Application.Runtime;
using UGF.Logs.Runtime;
using UGF.Module.Serialize.Runtime;
using UGF.Module.Serialize.Utf8Json.Runtime.Resolvers;
using UGF.Utf8Json.Runtime;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    public class SerializeUtf8JsonModule : ApplicationModuleBase, ISerializeUtf8JsonModule
    {
        public IApplication Application { get; }
        public ISerializeUtf8JsonModuleDescription Description { get; }
        public IUtf8JsonFormatterResolver Resolver { get { return m_resolver; } }

        private readonly Utf8JsonFormatterResolver m_resolver = Utf8JsonUtility.CreateDefaultResolver();

        public SerializeUtf8JsonModule(IApplication application, ISerializeUtf8JsonModuleDescription description)
        {
            Application = application ?? throw new ArgumentNullException(nameof(application));
            Description = description ?? throw new ArgumentNullException(nameof(description));

            m_resolver.AddResolver(UGFModuleSerializeUtf8JsonRuntimeResolver.Instance);
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            var serializeModule = Application.GetModule<ISerializeModule>();

            serializeModule.Provider.Add(Description.BytesSerializerName, new SerializerUtf8JsonBytes(Resolver));
            serializeModule.Provider.Add(Description.TextCompactSerializerName, new SerializerUtf8Json(Resolver, false));
            serializeModule.Provider.Add(Description.TextReadableSerializerName, new SerializerUtf8Json(Resolver, true));

            Log.Debug($"SerializeUtf8JsonModule: register '3' serializers (DataTypesCount:'{serializeModule.Provider.DataTypesCount}'):" +
                      $"'{Description.BytesSerializerName}', '{Description.TextCompactSerializerName}', '{Description.TextReadableSerializerName}'.");
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            var serializeModule = Application.GetModule<ISerializeModule>();

            serializeModule.Provider.Remove<byte[]>(Description.BytesSerializerName);
            serializeModule.Provider.Remove<string>(Description.TextCompactSerializerName);
            serializeModule.Provider.Remove<string>(Description.TextReadableSerializerName);
        }
    }
}
