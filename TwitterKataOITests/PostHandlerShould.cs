using Moq;
using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class PostHandlerShould
    {
        private Mock<PostRepository> _postRepositoryMock;
        private Mock<UserRepository> _userRepositoryMock;
        private PostHandler _postHandler;
        private static readonly User _author = new User("Tom");
        private static readonly Tweet _tweet = new Tweet("Hello all!");
        private readonly PostTokens _postTokens = new PostTokens(new Post(_author, _tweet));

        [SetUp]
        public void Init()
        {
            _postRepositoryMock = new Mock<PostRepository>();
            _userRepositoryMock = new Mock<UserRepository>();
            _postHandler = new PostHandler(_postRepositoryMock.Object, _userRepositoryMock.Object);
        }
        
        [Test]
        public void AddAPostCorrectlyForNewUser()
        {
            _postHandler.Post(_postTokens);
            
            _postRepositoryMock.Verify(p => p.Add(It.Is<Post>(pt => pt.Author.Username == "Tom" && pt.Tweet.Message == "Hello all!")), Times.Once);
            _userRepositoryMock.Verify(p => p.Add(It.Is<User>(pt => pt.Username == "Tom")), Times.Once);
        }
    }
}