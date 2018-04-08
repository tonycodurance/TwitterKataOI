using Moq;
using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class TwitterPostFeature
    {
        private Mock<CommandGenerator> _commandGeneratorMock;
        private Mock<CommandExecutor> _commandExecutorMock;
        private Twitterminal _twitterminal;

        [SetUp]
        public void Init()
        {
            _commandGeneratorMock = new Mock<CommandGenerator>(new Tokenizer());
            _commandExecutorMock = new Mock<CommandExecutor>();
            _twitterminal = new Twitterminal(_commandGeneratorMock.Object, _commandExecutorMock.Object);
        }
        
        [Test]
        public void Post()
        {
            const string input = "Bob -> Hello world!";
            var expectedAuthor = new User("Bob");
            var expectedTweet = new Tweet("Hello world!");
            var postCommand = new PostCommand(new Post(expectedAuthor, expectedTweet));
            _commandGeneratorMock.Setup(cg => cg.GenerateCommand(input)).Returns(postCommand);
            
            _twitterminal.Execute(input);
            
            _commandGeneratorMock
                .Verify(cg => cg.GenerateCommand(input), Times.Once);
            _commandExecutorMock
                .Verify(ce => ce.Execute(postCommand), Times.Once);
        }
    }
}