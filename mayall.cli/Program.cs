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
            if (!Parser.Default.ParseArguments(args, options, (verb, subOptions) => commands[verb].Execute(subOptions)))
            {
                Environment.Exit(Parser.DefaultExitCodeFail);
            }
        }
    }
}
