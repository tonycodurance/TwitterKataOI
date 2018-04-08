namespace TwitterKataOI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tm = new Twitterminal(new Tokenizer(), new PostHandler(new PostRepository(), new UserRepository()));
            
            tm.Execute("Tony -> Oh my god!");
        }
    }
}