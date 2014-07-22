using CommandLine;

namespace mayall.commands
{
    public class GlobalOptions
    {
        public GlobalOptions()
        {
            ConfigVerb = new ConfigOptions();
        }

        [VerbOption("config")]
        ConfigOptions ConfigVerb { get; set; }
    }
}
