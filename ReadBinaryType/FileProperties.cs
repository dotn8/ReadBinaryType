using System;

namespace ReadBinaryType
{
    public class FileProperties
    {
        public FileProperties(string value)
        {
            Value = value;
            BinaryType = Utility.GetBinaryType(value);
        }

        public string Value { get; set; }
        public BinaryType BinaryType { get; set; }
        public string ToCsvLine()
        {
            return String.Join(",\t", Value, BinaryType.ToString());
        }
    }
}