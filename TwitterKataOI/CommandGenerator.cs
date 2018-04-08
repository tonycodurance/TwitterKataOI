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
            var post = new Post(postTokens.GetUser(), postTokens.GetTweet());

            return new PostCommand(post);
        }
    }
}