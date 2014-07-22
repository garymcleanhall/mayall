using System;

namespace mayall.commands
{
    public class ConfigCommand : ICommand<ConfigOptions>
    {
        public void Execute(ConfigOptions context)
        {
            Console.WriteLine("Config!");
        }
    }
}
