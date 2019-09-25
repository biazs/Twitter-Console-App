using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Console
{
    class TweetManagerFile
    {
        private string fileName = "tweets.txt";

        public string PostTweet(string tweet)
        {
            if (tweet.Length > 140)
                return "Error: Tweet is longer than 140 chars.";

            if (TweetCounter() >= GetTweets().Length)
                return "Error: Max tweets reached.";

            System.IO.File.AppendAllLines(fileName, new string[] { tweet });

            return "Tweet posted successfully.";
        }

        public int TweetCounter()
        {
            return 0;
        }
        public string[] GetTweets()
        {
            return new string[3];
        }
    }
}
