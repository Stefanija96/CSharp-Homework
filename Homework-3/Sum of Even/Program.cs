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

            int[] numbers = new int[6];
            int result = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter integer no." + (i + 1) + ": ");
                string inputNum = Console.ReadLine();

                bool parsedNum = int.TryParse(inputNum, out int number);

                if (parsedNum)
                {
                    numbers[i] = number;
                    if (number % 2 == 0) result += number;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please try again!");
                    i--;
                }
            }

            Console.WriteLine("The result is: " + result);
        }
    }
}
