using System;
using UnityEngine;

namespace UGF.Module.Serialize.Utf8Json.Runtime
{
    [Serializable]
    public class SerializeUtf8JsonModuleDescription : ISerializeUtf8JsonModuleDescription
    {
        [SerializeField] private string m_bytesSerializerName = SerializerUtf8JsonUtility.SerializerBytesName;
        [SerializeField] private string m_textCompactSerializerName = SerializerUtf8JsonUtility.SerializerTextCompactName;
        [SerializeField] private string m_textReadableSerializerName = SerializerUtf8JsonUtility.SerializerTextReadableName;

        public string BytesSerializerName { get { return m_bytesSerializerName; } set { m_bytesSerializerName = value; } }
        public string TextCompactSerializerName { get { return m_textCompactSerializerName; } set { m_textCompactSerializerName = value; } }
        public string TextReadableSerializerName { get { return m_textReadableSerializerName; } set { m_textReadableSerializerName = value; } }
    }
}
