using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Console
{
    class TweetManager
    {
        string[] tweets = new string[10];
        int tweetCounter = 0;

        public string PostTweet(string tweet)
        {
            if (tweet.Length > 140)
                return "Error: Tweet is longer than 140 chars.";

            if (tweetCounter >= tweets.Length)
                return "Error: Max tweets reached.";

            tweets[tweetCounter++] = tweet;
            return "Tweet posted successfully.";
        }

        public int TweetCounter()
        {
            return tweetCounter;
        }
        public string[] GetTweets()
        {
            return tweets;
        }
    }
}
