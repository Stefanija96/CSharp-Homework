using System;
using System.Collections.Generic;
using Task_1.Classes;
using Task_1.Enums;
using System.Linq;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal("Christopher", "brown", 7, Gender.Male),
                new Animal("Homer", "black", 3, Gender.Male),
                new Animal("Bella", "white", 5, Gender.Female),
                new Animal("Iris", "light brown", 1, Gender.Female),
                new Animal("Ajax", "brown", 2, Gender.Male),
                new Animal("Reggie", "red", 4, Gender.Male),
                new Animal("Armaggedon", "gold", 3, Gender.Male),
                new Animal("Beethoven", "brown", 11, Gender.Male),
                new Animal("Violet", "grey", 1, Gender.Female),
                new Animal("Athena", "black", 13, Gender.Female),
            };

            AnimalsAged5OrMore(animals);
            Console.WriteLine("------------");
            NamesStartWithA(animals);
            Console.WriteLine("------------");
            MaleBrownAnimals(animals);
            Console.WriteLine("------------");
            AnimalNameLongerThan10Char(animals);
        }

        public static void AnimalsAged5OrMore(List<Animal> animals)
        {
            List<Animal> animalAges = animals.Where(animal => animal.Age >= 5).ToList();

            Console.WriteLine($"Animals that are five or more than five years old:");
            animalAges.ForEach(animal =>
            {
                Console.WriteLine(animal.Name);
            });
        }
        public static void NamesStartWithA(List<Animal> animals)
        {
            List<Animal> animalName = animals.Where(animal => animal.Name.StartsWith("A")).ToList();
            Console.WriteLine("Animals which names start with A");
            animalName.ForEach(animal =>
            {
                Console.WriteLine(animal.Name);
            });
        }
        public static void MaleBrownAnimals(List<Animal> animals)
        {
            List<Animal> maleBrownAnimals = animals.Where(animal => animal.Color == "brown" && animal.Gender == Gender.Male).ToList();
            Console.WriteLine("All male brown animals: ");
            maleBrownAnimals.ForEach(animal =>
            {
                Console.WriteLine(animal.Name);
            });
        }
        public static void AnimalNameLongerThan10Char(List<Animal> animals)
        {
            Animal longerThanTenChar = animals.Where(animal => animal.Name.Length > 10).First();
            Console.WriteLine($"Animal which name is longer than 10 characters: {longerThanTenChar.Name}");

        }
    }



}
