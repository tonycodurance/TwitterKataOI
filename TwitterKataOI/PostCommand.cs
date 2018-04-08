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
        }

        public void Execute()
        {
//            _postHandler.Post(_post.Tweet);
            _userHandler.AddUser(_post.Author);
        }
    }
}