namespace TwitterKataOI
{
    public class PostTokens
    {
        private readonly Post _post;

        public PostTokens(Post post)
        {
            _post = post;
        }
        
        public virtual Post GetPost()
        {
            return _post;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PostTokens postTokens))
                return false;

            return _post.Tweet.Message == postTokens.GetPost().Tweet.Message
                   && _post.Author.Username == postTokens.GetPost().Author.Username;
        }
    }
}