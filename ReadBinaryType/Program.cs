using System;

namespace ReadBinaryType
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                if (options.CsvHeaders)
                {
                    Console.WriteLine("Type,File name");
                }

                foreach (string fileName in options.FileNames)
                {
                    Console.WriteLine(new FileProperties(fileName).ToCsvLine());
                }

                if (options.Interactive)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            else
            {
                options.GetUsage();
            }
        }
    }
}