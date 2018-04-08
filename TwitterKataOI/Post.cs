namespace TwitterKataOI
{
    public class Post
    {
        public Post(User author, Tweet tweet)
        {
            Author = author;
            Tweet = tweet;
        }

        public User Author { get; }
        public Tweet Tweet { get; }
    }
}