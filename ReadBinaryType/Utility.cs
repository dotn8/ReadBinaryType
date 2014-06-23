using System;
using System.Runtime.InteropServices;

namespace ReadBinaryType
{
    public static class Utility
    {
        public static String BinaryTypeToString(this BinaryType binaryType)
        {
            switch (binaryType)
            {
                case BinaryType.SCS_32BIT_BINARY:
                    return "32-bit Windows-based application";
                case BinaryType.SCS_64BIT_BINARY:
                    return "64-bit Windows-based application";
                case BinaryType.SCS_DOS_BINARY:
                    return "MS-DOS-based application";
                case BinaryType.SCS_OS216_BINARY:
                    return "16-bit OS/2-based application";
                case BinaryType.SCS_POSIX_BINARY:
                    return "POSIX-based application";
                case BinaryType.SCS_WOW_BINARY:
                    return "16-bit Windows-based application";
                default:
                    return "Unknown";
            }
        }

        public static BinaryType GetBinaryType(string fileName)
        {
            BinaryType binaryType;
            GetBinaryType(fileName, out binaryType);
            return binaryType;
        }

        [DllImport("kernel32.dll")]
        private static extern bool GetBinaryType(string lpApplicationName,
                                                 out BinaryType lpBinaryType);

    }
}