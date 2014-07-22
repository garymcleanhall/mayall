using CommandLine;

namespace mayall.commands
{
    public class GlobalOptions
    {
        public GlobalOptions()
        {
            ConfigVerb = new ConfigOptions();
        }

        [VerbOption("config", HelpText = "Used to configure mayall settings")]
        ConfigOptions ConfigVerb { get; set; }
    }
}
