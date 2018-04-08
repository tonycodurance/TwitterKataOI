using NUnit.Framework;
using TwitterKataOI;

namespace TwitterKataOITests
{
    [TestFixture]
    public class UserRepositoryShould
    {
        private UserRepository _userRepository;

        [SetUp]
        public void Init()
        {
            _userRepository = new UserRepository();
        }
        
        [Test]
        public void AddUserCorrectly()
        {
            var user = new User("Tony");
            
            _userRepository.Add(user);
            
            CollectionAssert.Contains(_userRepository.GetUsers(), user);
        }
    }
}