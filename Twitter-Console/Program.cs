using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterManager;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            string choice;
            TweetManagerFile tm = new TweetManagerFile();
            do
            {
                Console.WriteLine("------Main Menu------");
                Console.WriteLine();
                Console.WriteLine("1. View All Tweets");
                Console.WriteLine("2. Post new Post");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    for (int i = 0; i < tm.TweetCounter(); i++)
                        Console.WriteLine("Tweet {0}:{1}", i + 1, tm.GetTweets()[i]);


                }
                if (choice == "2")
                {
                    Console.WriteLine("Enter your tweet: ");
                    string tweet = Console.ReadLine();
                    string msg = tm.PostTweet(tweet);
                    Console.WriteLine(msg);
                }

                if (choice == "3")
                {
                    Console.WriteLine("Enter search term: ");
                    string search = Console.ReadLine();
                    List<string> results = tm.Search(search);
                    Console.WriteLine("Found " + results.Count + " tweets.");
                }

                Console.WriteLine("You entered {0}", choice);

            }
            while (choice != "4");

            Console.ReadLine();

        }
    }
}
