using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic Light...");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red Light - STOP!");

            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow Light - PREPARE...");
                
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green Light - GO!");

            Console.WriteLine("");

            Console.ResetColor();
        }
    }
}
