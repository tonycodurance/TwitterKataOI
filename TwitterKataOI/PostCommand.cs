namespace TwitterKataOI
{
    public class PostCommand : ITwitterCommand
    {
        private readonly Post _post;
        private readonly PostHandler _postHandler;
        private readonly UserHandler _userHandler;

        public PostCommand(Post post)
        {
            _post = post;
            _postHandler = new PostHandler();
            _userHandler = new UserHandler();
        }

        public void Execute()
        {
            _postHandler.AddPost(_post);
            _userHandler.AddUser(_post.Author);
        }
    }
}