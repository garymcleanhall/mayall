using CommandLine;

namespace mayall.commands
{
    
    public class ConfigOptions
    {
        [Option('u', "username", HelpText = "Username for mail account")]
        public string Username { get; set; }

        //[Option('s', "server")]
        //public string Server { get; set; }

        //[Option('e', "email")]
        //public string Email { get; set; }

        //[Option('p', "port")]
        //public int Port { get; set; }

        //[Option('m', "security")]
        //public SecurityMode SecurityMode { get; set; }
    }

    public enum SecurityMode
    {
        None,
        Tls,
        Ssl
    }
}
