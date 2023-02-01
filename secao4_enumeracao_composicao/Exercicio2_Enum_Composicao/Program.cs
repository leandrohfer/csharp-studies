using System;
using System.Collections.Generic;
using Exercicio2_Composicao.Entities;

namespace Exercicio2_Composicao
{
    class Program
    {
        static void Main(String[] args)
        {
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");

            DateTime date = DateTime.Parse("21/06/2018 13:05:44");
            Post post = new Post(date, "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
            post.AddComment(comment1);
            post.AddComment(comment2);

            Console.WriteLine(post);

            Console.WriteLine();

            comment1 = new Comment("Good night");
            comment2 = new Comment("May the Force be with you");

            date = DateTime.Parse("28/07/2018 23:14:19");
            Post post2 = new Post(date, "Good night guys", "See you tomorrow", 5);
            post2.AddComment(comment1);
            post2.AddComment(comment2);

            Console.WriteLine(post2);
        }
    }
}
