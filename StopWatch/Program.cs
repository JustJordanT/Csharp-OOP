using System;

namespace StopWatch
{
    internal class Program
    {
        private static object TimeSpan;

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Stop watch: ");
            // Console.WriteLine("Would you like to 'start' or 'stop'?");
            // Console.WriteLine("Enter your option: ");
            // var i = Console.ReadLine();
            // var option = int.Parse(i);

            Console.WriteLine("Press 1 to start, 2 to stop");
            while (true)
            {
                var input = Console.ReadKey(true).KeyChar;
                Console.WriteLine($"You pressed {input}");
                
                var startWatch = new Start();
                var start = startWatch.StartTimer(); //.ToString("h:mm:ss tt")
                
                var stopWatch = new Stop();
                var stop = stopWatch.StopTimer();
                
                switch (input)
                {
                    case '1':
                    {
                        
                        Console.WriteLine($"Input 1 was selected - Timer was started at ({start})");
                        break;
                    }
                    case '2':
                    {
                        
                        Console.WriteLine($"Input 1 was selected - Timer was started at ({stop})");

                        

                        Console.WriteLine();
                        break;
                    }
                    case '3':
                    {
                        var tot = stop.Subtract(start).ToString("g");
                        Console.WriteLine(tot);
                        break;
                    }
                }
            }
        }
    }
}