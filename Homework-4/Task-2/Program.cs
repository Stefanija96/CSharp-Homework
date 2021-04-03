using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a Method that takes an integer minutes and converts it to seconds.


            Console.WriteLine("Enter minutes: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine(MinToSec(min));

        }
        static int MinToSec(int min)
        {

            return min * 60;
        }
    }
}
