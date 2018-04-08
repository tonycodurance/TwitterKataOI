namespace TwitterKataOI
{
    public class CommandGenerator
    {
        private readonly Tokenizer _tokenizer;

        public CommandGenerator(Tokenizer tokenizer)
        {
            _tokenizer = tokenizer;
        }

        public virtual ITwitterCommand GenerateCommand(string input)
        {            
            var postTokens = _tokenizer.Tokenize(input);
            var post = new Post(postTokens.GetPost().Author, postTokens.GetPost().Tweet);

            return new PostCommand(post);
        }
    }
}