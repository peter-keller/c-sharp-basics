﻿using System;
using System.Collections.Generic;

namespace MatchMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> {"Eve", "Ashley", "Bözsi", "Kat", "Jane"};
            var boys = new List<string> {"Joe", "Fred", "Béla", "Todd", "Neef", "Jeff"};

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...
            foreach (var item in MakingMatches(girls, boys))
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }

        public static List<string> MakingMatches(List<string> firstList, List<string> secondList)
        {
            var order = new List<string> ();
            for (int i = 0; i < firstList.Count; i++)
            {
                order.Add(firstList[i] + " - " + secondList[i]);
                
            }
            return order;
        }
    }
}
