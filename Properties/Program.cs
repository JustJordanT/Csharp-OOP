using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1990, 10, 6));
            Console.WriteLine(person.Age);
        }
    }
}