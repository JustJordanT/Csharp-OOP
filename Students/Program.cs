using System;

namespace Students
{
    
    //Making Methods Objects.
    internal static class Program
    {
        private static void Main(string[] args)                                         
        {
            var student1 = new Students("Jimmy", 3.4, "Computer Science");
            var student2 = new Students("Sammy", 2.9, "Nursing");
            var student3 = new Students("John", 2.5, "Computer Science");
            var student4 = new Students("Lucas", 3.0, "Mathematics");
            var student5 = new Students("Hailea", 3.9, "Engineering");
            var student6 = new Students("Amaiah", 3.9);
            var student7 = new Students("Amaiah", 4.5);

            // student7.Gpa = 4.9;
            
            
            Console.WriteLine(student4.HasHonors());
            Console.WriteLine(student4.IsStem());
            Console.WriteLine();
            Console.WriteLine($"The following student ({student6.name}) and has the following major ({student6.major})");
            Console.WriteLine(student4.Gpa);
            Console.WriteLine(student7.Gpa);
            
        }
    }
}