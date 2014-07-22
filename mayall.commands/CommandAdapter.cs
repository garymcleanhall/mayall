
namespace mayall.commands
{
    public class CommandAdapter<TOptions> : ICommand
    {
        public CommandAdapter(ICommand<TOptions> command)
        {
            this.command = command;
        }

        public void Execute(object context)
        {
            command.Execute((TOptions)context);
        }

        private readonly ICommand<TOptions> command;
    }
}
