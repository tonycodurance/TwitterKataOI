namespace TwitterKataOI
{
    public class PostHandler
    {
        private readonly PostRepository _postRepository;
        private readonly UserRepository _userRepository;

        public PostHandler(PostRepository postRepository, UserRepository userRepository)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
        }

        public virtual void Post(PostTokens postTokens)
        {
            _postRepository.Add(postTokens.GetPost());
            _userRepository.Add(postTokens.GetPost().Author);
        }
    }
}