using System;

namespace Sum_of_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //Make a console application called SumOfEven. Inside it create an array of 6 integers.
            //Get numbers from the input, find and print the sum of the even numbers from the array

            int[] arrayOfIntegers = new int[6];

            Console.WriteLine("Enter the first number:");
            arrayOfIntegers[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            arrayOfIntegers[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            arrayOfIntegers[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number:");
            arrayOfIntegers[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth number:");
            arrayOfIntegers[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sixth number:");
            arrayOfIntegers[5] = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] % 2 == 0)
                {
                    result += arrayOfIntegers[i];
                }
            }
            Console.WriteLine("The result is: " + result);
        }
    }
}
