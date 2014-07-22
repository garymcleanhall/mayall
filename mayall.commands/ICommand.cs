
namespace mayall.commands
{
    public interface ICommand
    {
        void Execute(object context);
    }

    public interface ICommand<in T>
    {
        void Execute(T context);
    }
}
