using CommandLine;
using CommandLine.Text;

namespace ReadBinaryType
{
    public class Options
    {
        [Option('i', "interactive", DefaultValue = false,
            HelpText =
                "Specifies whether or not to run in interactive mode. If running in interactive mode, the program will prompt for exit rather than exiting immediately."
            , Required = false)]
        public bool Interactive { get; set; }

        [Option('h', "headers", DefaultValue = false,
            HelpText =
                "Specifies whether or not output CSV headers."
            , Required = false)]
        public bool CsvHeaders { get; set; }

        [OptionArray('f', "filenames", HelpText = "Specifies the filenames to examine. Separate multiple filenames with a : character (a colon).", Required = true)]
        public string[] FileNames { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
                                      (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}