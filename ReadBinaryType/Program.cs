using System;
using System.Runtime.InteropServices;

namespace ReadBinaryType
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool GetBinaryType(string lpApplicationName,
                                                 out BinaryType lpBinaryType);

        private static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(GetBinaryType(arg));
            }
        }

        private static string GetBinaryType(string fileName)
        {
            BinaryType binaryType;
            GetBinaryType(fileName, out binaryType);
            switch (binaryType)
            {
                case BinaryType.SCS_32BIT_BINARY:
                    return String.Format("32-bit Windows-based application,\t{0}", fileName);
                case BinaryType.SCS_64BIT_BINARY:
                    return String.Format("64-bit Windows-based application,\t{0}", fileName);
                case BinaryType.SCS_DOS_BINARY:
                    return String.Format("MS-DOS-based application,\t{0}", fileName);
                case BinaryType.SCS_OS216_BINARY:
                    return String.Format("16-bit OS/2-based application,\t{0}", fileName);
                case BinaryType.SCS_POSIX_BINARY:
                    return String.Format("POSIX-based application,\t{0}", fileName);
                case BinaryType.SCS_WOW_BINARY:
                    return String.Format("16-bit Windows-based application,\t{0}", fileName);
                default:
                    return "Unknown";
            }
        }
    }
}