using System.Collections.Generic;
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

        [OptionList('f', "filenames", Separator = ':', HelpText = "Specifies the filenames to examine. Separate multiple filenames with a : character (a colon).", Required = true)]
        public List<string> FileNames { get; set; }

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