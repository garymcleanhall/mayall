using System;

namespace mayall.commands
{
    public class ConfigCommand : ICommand<ConfigOptions>
    {
        public void Execute(ConfigOptions context)
        {
            Console.WriteLine("Config: {0}", context.Username);
            //Console.WriteLine("Config: {0} {1} {2} {3} {4}", context.Email, context.Server, context.Port, context.Username, context.SecurityMode);
        }
    }
}
