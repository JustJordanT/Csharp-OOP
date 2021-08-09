using System;
using System.Threading.Channels;

namespace Indexers
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var cookie = new HttpCookie {["name"] = "Jordan"};
            Console.WriteLine(cookie["name"]);
        }
    }
}