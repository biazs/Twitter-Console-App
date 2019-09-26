
namespace TweetManager
{
    public class TweetManagerFile : TweetManager
    {
        private string fileName = "tweets.txt";
        public override string WriteTweet(string tweet)
        {
            System.IO.File.AppendAllLines(fileName, new string[] { tweet });

            return "Tweet posted successfully.";
        }

        public override int TweetCounter()
        {
            if (System.IO.File.Exists(fileName))
                return System.IO.File.ReadAllLines(fileName).Length;
            else
                return 0;
        }
        public override string[] GetTweets()
        {
            if (System.IO.File.Exists(fileName))
                return System.IO.File.ReadAllLines(fileName);
            else
                return new string[0];
        }
    }
}
