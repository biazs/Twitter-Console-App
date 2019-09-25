using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterManager
{
    public abstract class TweetManager
    {
        int maxTweets = 10;
        public string PostTweet(string tweet)
        {
            if (tweet.Length > 140)
                return "Error: Tweet is longer than 140 chars.";

            if (TweetCounter() >= maxTweets)
                return "Error: Max tweets reached.";

            return WriteTweet(tweet);

        }
        public abstract string[] GetTweets();
        public abstract int TweetCounter();
        public abstract string WriteTweet(string tweet);
        public List<string> Search(string searchTerm)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < TweetCounter(); i++)
            {
                if (GetTweets()[i].Contains(searchTerm))
                    results.Add(GetTweets()[i]);
            }
            return results;
        }
    }
}
