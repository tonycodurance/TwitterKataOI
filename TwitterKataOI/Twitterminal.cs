namespace TwitterKataOI
{
    public class Twitterminal
    {
        private readonly CommandGenerator _commandGenerator;
        private readonly CommandExecutor _commandExecutor;

        public Twitterminal(CommandGenerator commandGenerator, CommandExecutor commandExecutor)
        {
            _commandGenerator = commandGenerator;
            _commandExecutor = commandExecutor;
        }

        public virtual void Execute(string input)
        {
            var command = _commandGenerator.GenerateCommand(input);
            _commandExecutor.Execute(command);
        }
    }
}