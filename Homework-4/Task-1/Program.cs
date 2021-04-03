using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a Method that takes an age in years and returns the age in days.


            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateAge(age));

        }
        public static int CalculateAge(int age)
        {

            return age * 365;

        }
    }
}
