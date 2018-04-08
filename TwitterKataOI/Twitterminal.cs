namespace TwitterKataOI
{
    public class Twitterminal
    {
        private readonly PostHandler _postHandler;
        private readonly Tokenizer _tokenizer;

        public Twitterminal(Tokenizer tokenizer, PostHandler postHandler)
        {
            _postHandler = postHandler;
            _tokenizer = tokenizer;
        }

        public virtual void Execute(string input)
        {
            var tokens = _tokenizer.Tokenize(input);
            
            _postHandler.Post(tokens);
        }
    }
}