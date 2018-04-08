namespace TwitterKataOI
{
    public class PostHandler
    {
        private readonly PostRepository _postRepository;

        public PostHandler()
        {
            _postRepository = new PostRepository();
        }

        public void AddPost(Post post)
        {
            _postRepository.Add(post);
        }
    }
}