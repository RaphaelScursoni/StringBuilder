﻿using System;
using System.Globalization;
using StringBuilders.Entities;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a Nice trip!");
            Comment c2 = new Comment("Show de bola!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new zealand",
                "I'm going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/06/2018 23:15:23"),
                "Good Night guys",
                "See you tomorrow",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
