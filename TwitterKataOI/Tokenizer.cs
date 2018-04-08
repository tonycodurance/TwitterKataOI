using System;

namespace TwitterKataOI
{
    public class Tokenizer
    {
        public virtual PostTokens Tokenize(string input)
        {
            var spaceAfterUsernameIndex  = input.IndexOf(' ');
            var username = input.Substring(0, spaceAfterUsernameIndex);

            var spaceAfterEndOfArrow = input.IndexOf('>') + 1;
            var startOfTweetMessage = spaceAfterEndOfArrow + 1;
            var message = input.Substring(startOfTweetMessage);

            var tweet = new Tweet(message);
            var user = new User(username);

            return new PostTokens(tweet, user);
        }
    }
}