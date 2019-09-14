using System;
using UGF.Utf8Json.Editor.ExternalType;

namespace UGF.Serialize.Utf8Json.Math.Editor.Tests
{
    public class Utf8JsonMathTypeGenerateInfo
    {
        public Type Type { get; }
        public int Count { get; }
        public bool IsVector { get; }

        public Utf8JsonMathTypeGenerateInfo(Type type, int count, bool isVector = true)
        {
            if (count < 0) throw new ArgumentException("Count can't be less then zero.'");

            Type = type ?? throw new ArgumentNullException(nameof(type));
            Count = count;
            IsVector = isVector;
        }
    }
}
