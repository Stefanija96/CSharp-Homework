using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 6
            
            Console.WriteLine("Please enter the first number");
            bool firstInput = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Please enter the second number");
            bool secondInput = int.TryParse(Console.ReadLine(), out int secondNumber);

            if (firstInput && secondInput)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(firstNumber + " is bigger than " + secondNumber);
                    int biggerNumber = firstNumber;
                    if (biggerNumber % 2 == 0)
                    {
                        Console.WriteLine("Number " + biggerNumber + " is even.");
                    }
                    else
                    {
                        Console.WriteLine("Number " + biggerNumber + " is odd.");
                    }
                }
                else if (firstNumber < secondNumber)
                {
                    Console.WriteLine(secondNumber + " is bigger than " + firstNumber);
                    int biggerNumber = secondNumber;
                    if (biggerNumber % 2 == 0)
                    {
                        Console.WriteLine("Number " + biggerNumber + " is even.");
                    }
                    else
                    {
                        Console.WriteLine("Number " + biggerNumber + " is odd.");
                    }
                }
                else
                {
                    Console.WriteLine("Numbers are equal.");
                }
            }
            else
            {
                Console.WriteLine("There was an error!");
            }
            Console.ReadLine();


             //EXERCISE 7

            //Console.WriteLine("Please enter a number from 1 to 3");
            //string number = Console.ReadLine();
            //int enteredNumber = int.Parse(number);

            //switch (enteredNumber)
            //{
            //    case 1:
            //        Console.WriteLine("You got a new car!");
            //        break;
            //    case 2:
            //        Console.WriteLine("You got a new plane!");
            //        break;
            //    case 3:
            //        Console.WriteLine("You got a new bike!");
            //        break;
            //    default:
            //        Console.WriteLine("There was some error.");
            //        break;
            //}
        }
    }
}
