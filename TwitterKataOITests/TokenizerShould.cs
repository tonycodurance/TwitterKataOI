using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class TokenizerShould
    {
        [Test]
        public void TokenizeCorrectlyForPost()
        {
            const string input = "Bob -> Hello world!";
            var tweet = new Tweet("Hello world!");
            var user = new User("Bob");
            var expectedTokens = new PostTokens(new Post(user, tweet));

            var tokens = new Tokenizer().Tokenize(input);
            
            Assert.AreEqual(tokens, expectedTokens);
        }
    }
}