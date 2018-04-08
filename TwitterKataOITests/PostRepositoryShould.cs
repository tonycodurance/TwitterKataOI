using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class PostRepositoryShould
    {
        private PostRepository _postRepository;
        
        [SetUp]
        public void Init()
        {
            _postRepository = new PostRepository();
        }
        
        [Test]
        public void AddPostCorrectly()
        {
            var post = new Post(new User("Tony"), new Tweet("Hello there!"));
            
            _postRepository.Add(post);
            
            CollectionAssert.Contains(_postRepository.GetPosts(), post);
        }
    }
}