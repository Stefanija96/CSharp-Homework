using System;

namespace Student_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 2

            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentsG2 = new string[] { "Aleksandra", "Veronika", "Ana", "Kristina", "Katerina" };

            while (true)
            {
                Console.Write("For the students from G1 enter 1, for the students for G2 enter 2: ");
                string inputNum = Console.ReadLine();

                bool parsedNum = int.TryParse(inputNum, out int num);

                if (parsedNum && (num == 1 || num == 2))
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("The students in G1 are:");
                            foreach (string student in studentsG1) Console.WriteLine(student);
                            break;

                        case 2:
                            Console.WriteLine("The students in G2 are:");
                            foreach (string student in studentsG2) Console.WriteLine(student);
                            break;
                    }
                    break;
                }
                else
                {
                    Console.Write("Please enter valid input ");
                    continue;
                }
            }
        }
    }
}
