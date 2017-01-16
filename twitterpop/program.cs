using System;
using twitterpop;

namespace demoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Post tweet.
                Tweet.postTweet("This is my first tweet with TwitterPop! #dotNET ");

                // Confirm succesfull post.
                Console.WriteLine("Tweet successfully posted.");
                Console.ReadKey();
            }
            catch
            {
                // Notify of error.
                Console.WriteLine("There was an issue posting your tweet.");
            }
        } 
    }
}
