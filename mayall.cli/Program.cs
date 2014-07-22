using System;
using System.Collections.Generic;

using CommandLine;

using mayall.commands;

namespace mayall.cli
{
    class Program
    {
        private static readonly IDictionary<string, ICommand> commands = new Dictionary<string, ICommand>
        {
            { "config", new CommandAdapter<ConfigOptions>(new ConfigCommand()) }
        };

        static void Main(string[] args)
        {
            var options = new GlobalOptions();
            if (!Parser.Default.ParseArgumentsStrict(args, options, DispatchVerbCommand))
            {
                Environment.Exit(Parser.DefaultExitCodeFail);
            }
        }

        private static void DispatchVerbCommand(string verb, object subOptions)
        {
            if (commands.ContainsKey(verb))
            {
                commands[verb].Execute(subOptions);
            }
        }
    }
}
