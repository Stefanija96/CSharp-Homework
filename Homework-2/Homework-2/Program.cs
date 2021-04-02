using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input
            //and asks what operation would the user want to be done( +, - , * , / ).
            //Then it returns the result.

            //Console.WriteLine("Please enter the first number");
            //bool firstInputToNumber = double.TryParse(Console.ReadLine(), out double numberA);

            //Console.WriteLine("Enter the second number");
            //bool secondInputToNumber = double.TryParse(Console.ReadLine(), out double numberB);

            //Console.WriteLine("Enter the operation");
            //bool operationInput = char.TryParse(Console.ReadLine(), out char operation);
            //if (firstInputToNumber && secondInputToNumber && operationInput)
            //{
            //    if (operation == '+')
            //    {
            //        double resultFromAdding = numberA + numberB;
            //        Console.WriteLine("The result is: " + resultFromAdding);
            //    }
            //    else if (operation == '-')
            //    {
            //        double resultFromSubstracting = numberA - numberB;
            //        Console.WriteLine("The result is: " + resultFromSubstracting);
            //    }
            //    else if (operation == '*')
            //    {
            //        double resultFromMultiplying = numberA * numberB;
            //        Console.WriteLine("The result is: " + resultFromMultiplying);
            //    }
            //    else if (operation == '/')
            //    {
            //        double resultFromDividing = numberA / numberB;
            //        Console.WriteLine("The result is: " + resultFromDividing);
            //    }
            //    else
            //    {
            //        Console.WriteLine("There was an error");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("There was an error!");
            //}
            //Console.ReadLine();

            //Task 2
            // Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            //Console.WriteLine("Enter the first number");
            //bool firstInput = double.TryParse(Console.ReadLine(), out double numberOne);

            //Console.WriteLine("Enter the second number");
            //bool secondInput = double.TryParse(Console.ReadLine(), out double numberTwo);

            //Console.WriteLine("Enter the third number");
            //bool thirdInput = double.TryParse(Console.ReadLine(), out double numberThree);

            //Console.WriteLine("Enter the fourth number");
            //bool fourthInput = double.TryParse(Console.ReadLine(), out double numberFour);

            //if (firstInput && secondInput && thirdInput && fourthInput)
            //{
            //    double averageNumber = (numberOne + numberTwo + numberThree + numberFour) / 4;
            //    Console.WriteLine("The average of " + numberOne + ", " + numberTwo + ", " + numberThree + " and " + numberFour + " is: " + averageNumber);
            //}
            //else
            //{
            //    Console.WriteLine("There was an error");
            //}
            //Console.ReadLine();

            //Task 3:
            //Create new console application “SwapNumbers”.
            //Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value
            //and the second variable the first value.

            Console.WriteLine("Enter the first Number");
            bool firstInput = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter the second Number");
            bool secondInput = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (firstInput && secondInput)
            {
                Console.WriteLine("Before swapping: First Number is " + firstNumber + " Second Number is " + secondNumber);
                firstNumber += secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber -= secondNumber;
                Console.WriteLine("After swapping: First Number is " + firstNumber + " Second Number is " + secondNumber);
            }
            else
            {
                Console.WriteLine("There was an error!");
            }
        }
    }
}
