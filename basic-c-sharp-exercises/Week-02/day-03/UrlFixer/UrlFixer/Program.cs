﻿using System;

namespace UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Replace("s/", "s:/");
            url = url.Replace("bots", "odds");

            Console.WriteLine(url);

            Console.ReadKey();
        }
    }
}
