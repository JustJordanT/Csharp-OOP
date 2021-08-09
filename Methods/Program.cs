using System;

namespace Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           UseOut();
        }

        static void UseOut()
        {
            // var numebr = int.Parse("abc");

            int number;
            var result=  int.TryParse("abc",out number);
            if (result)
                Console.WriteLine(number);
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        private static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(11, 2, 34, 5));
            Console.WriteLine(calculator.Add(1, 22, 34, 5));
            Console.WriteLine(calculator.Add(1, 2, 34, 5));
            Console.WriteLine(calculator.Add(1, 232, 34, 544));
            Console.WriteLine(calculator.Add(1, 2, 3, 3, 4, 4, 5));
        }

        private static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                // point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occured");
                // throw;
            }
        }
    }
}