using Moq;
using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class TwitterPostFeature
    {
        private Mock<Tokenizer> _tokenizerMock;
        private Mock<PostHandler> _postHandlerMock;
        private Twitterminal _twitterminal;

        [SetUp]
        public void Init()
        {
            _tokenizerMock = new Mock<Tokenizer>();
            _postHandlerMock = new Mock<PostHandler>(new Mock<PostRepository>().Object, new Mock<UserRepository>().Object);
            _twitterminal = new Twitterminal(_tokenizerMock.Object, _postHandlerMock.Object);
        }
        
        [Test]
        public void Post()
        {
            const string input = "Bob -> Hello world!";
            var expectedAuthor = new User("Bob");
            var expectedTweet = new Tweet("Hello world!");
            _tokenizerMock.Setup(t => t.Tokenize(input))
                .Returns(new PostTokens(new Post(expectedAuthor, expectedTweet)));
            _twitterminal.Execute(input);
            
            _tokenizerMock
                .Verify(t => t.Tokenize(input), Times.Once);
            _postHandlerMock
                .Verify(p => p.Post(It.Is<PostTokens>(
                    pt => pt.GetPost().Author.Username == "Bob" && pt.GetPost().Tweet.Message == "Hello world!")
                ), Times.Once);
        }
    }
}