using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task_2.Classes;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
           {
                new Person("Bill", "Smith", 41, 'M'),
                new Person("Sarah", "Jones", 22, 'F'),
                new Person("Stacy","Baker", 21, 'F'),
                new Person("Vivianne","Dexter", 19, 'F' ),
                new Person("Brett","Baker", 51, 'M' ),
                new Person("Mark","Parker", 19, 'M'),
                new Person("Alice","Thompson", 18, 'F'),
                new Person("Evelyn","Thompson", 58, 'F' ),
                new Person("Mort","Martin", 58, 'M'),
                new Person("Eugene","deLauter", 84, 'M' ),
                new Person("Gail","Dawson", 19, 'F' ),
           };
            //Task 01

            List<Person> peopleAged50OrMore = people.Where(person => person.Age >= 50).ToList();
            Console.WriteLine("People aged 50 or more:");
            FindPeople(peopleAged50OrMore);
            Console.WriteLine("---------");

            //Task 02:

            List<Person> peoplesNamesStartWithB = people.Where(person => person.FirstName.StartsWith("B")).ToList();
            Console.WriteLine("People name starts with B: ");
            FindPeople(peoplesNamesStartWithB);
            Console.WriteLine("---------");

            //Task 03:

            Person personSurnameStartsWithT = people.Where(person => person.LastName.StartsWith("T")).First();
            Console.WriteLine($"Person Last Name starts with T: {personSurnameStartsWithT.LastName} - {personSurnameStartsWithT.FirstName}  {personSurnameStartsWithT.LastName}");
            Console.WriteLine("---------");

            //Task 04:

            Person oldestPerson = people.OrderByDescending(person => person.Age).FirstOrDefault();
            Console.WriteLine($"Oldest person is: {oldestPerson.FirstName} {oldestPerson.LastName}");

            Person youngestPerson = people.OrderBy(person => person.Age).FirstOrDefault();
            Console.WriteLine($"Youngest person is: {youngestPerson.FirstName} {youngestPerson.LastName}");
            Console.WriteLine("---------");

            //Task 05:
            List<Person> maleAged45OrMore = people.Where(person => person.Gender.Equals('M') && person.Age >= 45).ToList();
            Console.WriteLine("Males aged 45 or more : ");
            FindPeople(maleAged45OrMore);
            Console.WriteLine("---------");

            //Task 06:

            List<Person> femalesWhoseNameStartsWithV = people.Where(person => person.Gender
            .Equals('F') && person.FirstName.StartsWith("V")).ToList();
            Console.WriteLine("Females whose name starts with V : ");
            FindPeople(femalesWhoseNameStartsWithV);
            Console.WriteLine("---------");

            //Task 07:

            Person lastFemalePerson = people.Where(person => person.Gender.Equals('F') && person.Age > 30 && person.FirstName.StartsWith("P")).LastOrDefault();
            if (lastFemalePerson == null)
            {
                Console.WriteLine("There is no such person");
            }
            else
            {
                Console.WriteLine($"Female person older than 30 whose name starts with P: {lastFemalePerson}");
            }
            Console.WriteLine("---------");

            //Task 08:

            Person firstMalePerson = people.Where(person => person.Gender.Equals('M') && person.Age < 40).FirstOrDefault();
            Console.WriteLine($"Male younger than 40 is : {firstMalePerson.FirstName} {firstMalePerson.LastName}");
            Console.WriteLine("---------");

            //Task 09:

            List<Person> malePeopleNameLongerThanSurname = people.Where(person => person.Gender.Equals('M') && person.FirstName.Length > person.LastName.Length).ToList();
            if (malePeopleNameLongerThanSurname.Count == 0)
            {
                Console.WriteLine("There is no such person");
            }
            else
            {
                Console.WriteLine($"Names of the male persons that have firstName longer than lastName: ");
                FindPeople(malePeopleNameLongerThanSurname);
            };
            Console.WriteLine("---------");


            //Task 10:

            List<Person> femalesWithOddNumberOfAges = people.Where(person => person.Age % 2 != 0 && person.Gender.Equals('F')).ToList();

            foreach (var person in femalesWithOddNumberOfAges)
            {
                Console.WriteLine( person.LastName);
            }
 

        }
        public static void FindPeople(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(($"{person.FirstName} {person.LastName}"));
            }
        }


    }
}
