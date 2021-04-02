using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a Method that takes an integer minutes and converts it to seconds.

            Console.WriteLine(minToSec());

        }
        static int minToSec()
        {
            Console.WriteLine("Enter minutes: ");
            int min = int.Parse(Console.ReadLine());
            return min * 60;
        }
    }
}
