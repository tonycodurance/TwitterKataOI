using Moq;
using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class PostHandlerShould
    {
        private Mock<PostRepository> _postRepositoryMock;
        private PostHandler _postHandler;
        private static readonly User _author = new User("Tom");
        private static readonly Tweet _tweet = new Tweet("Hello all!");
        private readonly Post _post = new Post(_author, _tweet);

        [SetUp]
        public void Init()
        {
            _postRepositoryMock = new Mock<PostRepository>();
            _postHandler = new PostHandler();
        }
        
        [Test]
        public void AddAPostCorrectlyForNewUser()
        {
            _postHandler.AddPost(_post);
            
            _postRepositoryMock.Verify(p => p.Add(It.Is<Post>(pt => pt.Author.Username == "Tom" && pt.Tweet.Message == "Hello all!")), Times.Once);
        }
    }
}