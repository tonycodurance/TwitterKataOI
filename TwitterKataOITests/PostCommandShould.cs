using Moq;
using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class PostCommandShould
    {
        private PostCommand _postCommand;
        private Mock<UserRepository> _userRepositoryMock;
        private Mock<PostRepository> _postRepositoryMock;
        private readonly User _author = new User("Tom");
        private readonly Tweet _tweet = new Tweet("Hello all!");

        [SetUp]
        public void Init()
        {
            _userRepositoryMock = new Mock<UserRepository>();
            _postRepositoryMock = new Mock<PostRepository>();
            _postCommand = new PostCommand(new Post(_author, _tweet));
        }
        [Test]
        public void Execute()
        {
            var post = new Post(_author, _tweet);
            
            _postCommand.Execute();
            
            _postRepositoryMock.Verify(p => p.Add(post), Times.Once);
            _userRepositoryMock.Verify(p => p.Add(_author), Times.Once);
        }
    }
}