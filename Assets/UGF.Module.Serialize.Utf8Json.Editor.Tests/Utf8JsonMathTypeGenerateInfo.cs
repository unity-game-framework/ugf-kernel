using System;

namespace UGF.Module.Serialize.Utf8Json.Editor.Tests
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
