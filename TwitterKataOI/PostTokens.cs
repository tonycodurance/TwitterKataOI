namespace TwitterKataOI
{
    public class PostTokens
    {
        private readonly Tweet _tweet;
        private readonly User _user;

        public PostTokens(Tweet tweet, User user)
        {
            _tweet = tweet;
            _user = user;
        }

        public User GetUser()
        {
            return _user;
        }

        public Tweet GetTweet()
        {
            return _tweet;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PostTokens postTokens))
                return false;
            
            return _tweet.Message == postTokens.GetTweet().Message &&
                   _user.Username == postTokens.GetUser().Username;
        }
    }
}