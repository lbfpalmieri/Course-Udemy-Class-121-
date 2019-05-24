using System;
using Course_class_121.Entities;

namespace Course_class_121
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("You very nice!");
            Comment c4 = new Comment("I lov you <3 !");
            Post p2 = new Post(
                DateTime.Parse("24/12/2019 14:10:10"),
                "Traveling to New York",
                "I'm going to visit this big country",
                12);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
