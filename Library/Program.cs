using System;

//This Project we learn more about classes and object and contractors.

namespace Library
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var book1 = new Book("Star Wars - Empire Strikes Back", "George Lucas", 600);
            var book2 = new Book("Star Wars", "George Lucas", 600);

            Console.WriteLine(book1.title);
        }
    }
}