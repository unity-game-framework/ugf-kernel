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

        private readonly Utf8JsonFormatterResolver m_resolver = Utf8JsonUtility.CreateDefaultResolver();

        public SerializeUtf8JsonModule(IApplication application)
        {
            Application = application ?? throw new ArgumentNullException(nameof(application));

            m_resolver.Resolvers.Add(UGFModuleSerializeUtf8JsonRuntimeResolver.Instance);
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            if (Application.TryGetModule(out ISerializeModule module))
            {
                string bytesName = SerializerUtf8JsonUtility.SerializerBytesName;
                string compactName = SerializerUtf8JsonUtility.SerializerTextCompactName;
                string readableName = SerializerUtf8JsonUtility.SerializerTextReadableName;

                module.Provider.Add(bytesName, new SerializerUtf8JsonBytes(Resolver));
                module.Provider.Add(compactName, new SerializerUtf8Json(Resolver, false));
                module.Provider.Add(readableName, new SerializerUtf8Json(Resolver, true));

                Log.Debug($"SerializeUtf8JsonModule: register '3' serializers (DataTypesCount:'{module.Provider.DataTypesCount}'): '{bytesName}', '{compactName}', '{readableName}'.");
            }
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            if (Application.TryGetModule(out ISerializeModule module))
            {
                string bytesName = SerializerUtf8JsonUtility.SerializerBytesName;
                string compactName = SerializerUtf8JsonUtility.SerializerTextCompactName;
                string readableName = SerializerUtf8JsonUtility.SerializerTextReadableName;

                module.Provider.Remove<byte[]>(bytesName);
                module.Provider.Remove<string>(compactName);
                module.Provider.Remove<string>(readableName);
            }
        }
    }
}
