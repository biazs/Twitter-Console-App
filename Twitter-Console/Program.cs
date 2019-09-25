using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tweets = new string[4];

            for (int i = 0; i < tweets.Length; i++)
            {
                Console.Write("Enter tweet {0}: ", i + 1);
                tweets[i] = Console.ReadLine();
            }

            Console.WriteLine("Tweets posted successfully.");
            Console.WriteLine();

            for (int i = 0; i < tweets.Length; i++)
            {
                if (tweets[i].Length > 140)
                    Console.WriteLine("Tweet is longer than 140 chars.");

                else
                    Console.WriteLine("Tweet {0}", i + 1 + ": " + tweets[i]);

            }

            Console.ReadLine();
        }
    }
}
