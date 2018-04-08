namespace TwitterKataOI
{
    public class CommandExecutor
    {
        public virtual void Execute(ITwitterCommand command)
        {
            command.Execute();
        }
    }
}