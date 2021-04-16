using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you want to store");
            List<int> listOfIntegers = new List<int>();
            Queue<int> queueOfIntegers = new Queue<int>();
            Stack<int> stackOfIntegers = new Stack<int>();
            bool anotherAction = false;
            while (!anotherAction)
            {
                string userInput = Console.ReadLine();
                int parsedInput = int.Parse(userInput);
                AddingANumberInList(listOfIntegers, parsedInput);
                AddingANumberInQueue(queueOfIntegers, parsedInput);
                AddingANumberInStack(stackOfIntegers, parsedInput);
                Console.WriteLine("Do you want to add another number? Y/N");
                string yesOrNo = Console.ReadLine();

                if (yesOrNo.ToLower() == "y")
                {
                    Console.WriteLine("Enter a number you want to store.");
                }
                else if (yesOrNo.ToLower() == "n")
                {
                    Console.WriteLine("Elements from the list!");
                    foreach (var number in listOfIntegers)
                    {

                        Console.Write("{0}  ", number);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Elements from the queue!");
                    foreach (var number in queueOfIntegers)
                    {

                        Console.Write("{0}  ", number);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Elements from the stack!");
                    foreach (var number in stackOfIntegers)
                    {
                        Console.Write("{0}  ", number);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Elements from the stack reversed!");
                    Stack<int> reversed = new Stack<int>();
                    while (stackOfIntegers.Count != 0)
                    {
                        reversed.Push(stackOfIntegers.Pop());
                    }
                    foreach (var number in reversed)
                    {

                        Console.Write("{0}  ", number);
                    }

                    anotherAction = !anotherAction;
                }

            }


        }
        public static void AddingANumberInList(List<int> listOfNumbers, int number)
        {
            listOfNumbers.Add(number);
        }
        public static void AddingANumberInQueue(Queue<int> queueOfNumbers, int number)
        {
            queueOfNumbers.Enqueue(number);
        }
        public static void AddingANumberInStack(Stack<int> stackOfNumbers, int number)
        {
            stackOfNumbers.Push(number);
            
        }
    }

}
