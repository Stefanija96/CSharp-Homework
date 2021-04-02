using System;

namespace Student_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 2

            string[] studentG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentG2 = new string[] { "Aleksandra", "Veronika", "Ana", "Kristina", "Katerina" };

            Console.WriteLine("Enter either 1 or 2");

            int numberFromInput = int.Parse(Console.ReadLine());
            if (numberFromInput == 1)
            {
                Console.WriteLine("The students in G1 are: " + studentG1[0] + "," + studentG1[1] + "," + studentG1[2] + "," + studentG1[3] + "," + studentG1[4]);
            }
            else if (numberFromInput == 2)
            {
                Console.WriteLine("The students in G2 are: " + studentG2[0] + "," + studentG2[1] + "," + studentG2[2] + "," + studentG2[3] + "," + studentG2[4]);
            }
            else
            {
                Console.WriteLine("You have entered a wrong number.");
            }
        }
    }
}
