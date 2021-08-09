using System;

namespace StackOverflow
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var post1 = new Post("Tavi", "My first Blog Post", "This is my first blog post");
            var post2 = new Post("Jordan", "Learning C#", "This is a blob about C#");

            
            
            
            Console.WriteLine(post2.Title);
            Console.WriteLine(post2.Vote);
            Console.WriteLine(post2.UpVote());
            Console.WriteLine(post2.UpVote());
            Console.WriteLine(post2.UpVote());
            post2.UpVote();
            post2.DownVote();
            Console.WriteLine(post2.Vote);
            Console.WriteLine();
            Console.WriteLine(post1.Vote);
        }
    }
}