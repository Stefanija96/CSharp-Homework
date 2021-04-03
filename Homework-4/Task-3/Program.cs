using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Create a function that takes the number of wins, draws and losses and
            //calculates the number of points a football team has obtained so far.

            Console.Write("Enter the number of wins: ");
            int wins = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the number of draws: ");
            int draws = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the number of looses: ");
            int losses = Int32.Parse(Console.ReadLine());
            int res = NumberOfPoints(wins, draws, losses);
            Console.WriteLine($"The footbal team has {res} points");

        }
        static int NumberOfPoints(int wins, int draws, int losses)
        {
            int numberOfWins  = wins * 3;
            int numberOfDraws = draws * 1;
            int numberOfLosses = losses * 0;

            return numberOfWins + numberOfDraws + numberOfLosses;
        }

    }
}
