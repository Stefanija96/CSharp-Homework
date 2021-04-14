using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                NumberStats();
                Console.WriteLine("Would you like to enter another number? (Y/X)");
                string yesNo = Console.ReadLine();
                if (yesNo != "y") break;

            }

            static void NumberStats()
            {
                Console.WriteLine("Please enter a number:");
                bool boolNum = double.TryParse(Console.ReadLine(), out double number);
                if (!boolNum)
                {
                    Console.WriteLine("Please enter a valid input!");
                }
                else
                {
                    Console.WriteLine($"Stats for number: {number} ");

                    if (number > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else
                    {
                        Console.WriteLine("Negative");
                    }

                    if (number % 1 == 0)
                    {
                        Console.WriteLine("Integer");
                    }
                    else
                    {
                        Console.WriteLine("Decimal");
                    }
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                }
            }
        }
    }
}
