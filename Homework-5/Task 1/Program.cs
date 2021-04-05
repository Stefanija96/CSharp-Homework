using System;
using Task_1.Classes;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            RaceCars racingMethods = new RaceCars();
            Car hyundai = new Car("Hyundai", 180);
            Car mazda = new Car("Mazda", 150);
            Car ferrari = new Car("Ferrari", 170);
            Car porsche = new Car("Porsche", 130);


            Driver bob = new Driver("Bob", 9);
            Driver greg = new Driver("Greg", 7);
            Driver jill = new Driver("Jill", 6);
            Driver ane = new Driver("Ane", 8);
            while (true)
            {
                //CHOOSING FIRST CAR
                Console.WriteLine($"Choose a car No.1 with a number:\n1.{hyundai.Model}\n2.{mazda.Model}\n3.{ferrari.Model}\n4.{porsche.Model}");

                bool parsedInputCar = int.TryParse(Console.ReadLine(), out int firstCarInput);
                string firstCarModel = "";
                int firstCarSpeed = 0;
                if (parsedInputCar)
                {
                    switch (firstCarInput)
                    {
                        case 1:
                            firstCarModel = hyundai.Model;
                            firstCarSpeed = hyundai.Speed;
                            break;
                        case 2:
                            firstCarModel = mazda.Model;
                            firstCarSpeed = mazda.Speed;
                            break;
                        case 3:
                            firstCarModel = ferrari.Model;
                            firstCarSpeed = ferrari.Speed;
                            break;
                        case 4:
                            firstCarModel = porsche.Model;
                            firstCarSpeed = porsche.Speed;
                            break;
                    };

                }

                //CHOOSING FIRST DRIVER
                Console.WriteLine($"Choose a Driver No.1 with a number:\n1.{bob.Name}\n2.{greg.Name}\n3.{jill.Name}\n4.{ane.Name}");
                bool parsedInputDriver = int.TryParse(Console.ReadLine(), out int firstDriverInput);
                string firstDriverName = "";
                int firstDriverSkill = 0;
                if (parsedInputDriver)
                {
                    switch (firstDriverInput)
                    {
                        case 1:
                            firstDriverName = bob.Name;
                            firstDriverSkill = bob.Skill;
                            break;
                        case 2:
                            firstDriverName = greg.Name;
                            firstDriverSkill = greg.Skill;
                            break;
                        case 3:
                            firstDriverName = jill.Name;
                            firstDriverSkill = jill.Skill;
                            break;
                        case 4:
                            firstDriverName = ane.Name;
                            firstDriverSkill = ane.Skill;
                            break;
                    };

                }

                Car carOne = new Car(firstCarModel, firstCarSpeed);
                Driver driverOne = new Driver(firstDriverName, firstDriverSkill);
                carOne.Driver = driverOne;

                //SECOND CAR
                string secondCarModel = "";
                int secondCarSpeed = 0;
                if (carOne.Model == "Hyundai")
                {
                    Console.WriteLine("Choose a car No.2 with a number:");
                    Console.WriteLine($"1.{mazda.Model}\n2.{ferrari.Model}\n3.{porsche.Model}");
                    string carTwoInput = Console.ReadLine();

                    switch (carTwoInput)
                    {
                        case "1":
                            secondCarModel = mazda.Model;
                            secondCarSpeed = mazda.Speed;
                            break;
                        case "2":
                            secondCarModel = ferrari.Model;
                            secondCarSpeed = ferrari.Speed;
                            break;
                        case "3":
                            secondCarModel = porsche.Model;
                            secondCarSpeed = porsche.Speed;
                            break;
                    };
                }

                if (carOne.Model == "Mazda")
                {
                    Console.WriteLine("Choose a car No.2 with a number:");

                    Console.WriteLine($"1.{hyundai.Model}\n2.{ferrari.Model}\n3.{porsche.Model}");
                    string carTwoInput = Console.ReadLine();
                    switch (carTwoInput)
                    {
                        case "1":
                            secondCarModel = hyundai.Model;
                            secondCarSpeed = hyundai.Speed;
                            break;
                        case "2":
                            secondCarModel = ferrari.Model;
                            secondCarSpeed = ferrari.Speed;
                            break;
                        case "3":
                            secondCarModel = porsche.Model;
                            secondCarSpeed = porsche.Speed;
                            break;
                    };
                }

                if (carOne.Model == "Ferrari")
                {
                    Console.WriteLine("Choose a car No.2 with a number:");

                    Console.WriteLine($"1.{hyundai.Model}\n2.{mazda.Model}\n3.{porsche.Model}");
                    string carTwoInput = Console.ReadLine();
                    switch (carTwoInput)
                    {
                        case "1":
                            secondCarModel = hyundai.Model;
                            secondCarSpeed = hyundai.Speed;
                            break;
                        case "2":
                            secondCarModel = mazda.Model;
                            secondCarSpeed = mazda.Speed;
                            break;
                        case "3":
                            secondCarModel = porsche.Model;
                            secondCarSpeed = porsche.Speed;
                            break;
                    };
                }

                if (firstCarModel == "Porsche")
                {
                    Console.WriteLine("Choose a car No.2 with a number:");
                    Console.WriteLine($"1.{hyundai.Model}\n2.{mazda.Model}\n3.{ferrari.Model}");
                    string carTwoInput = Console.ReadLine();
                    switch (carTwoInput)
                    {
                        case "1":
                            secondCarModel = hyundai.Model;
                            secondCarSpeed = hyundai.Speed;
                            break;
                        case "2":
                            secondCarModel = mazda.Model;
                            secondCarSpeed = mazda.Speed;
                            break;
                        case "3":
                            secondCarModel = ferrari.Model;
                            secondCarSpeed = ferrari.Speed;
                            break;
                    };
                }

                //SECOND DRIVER
                string secondDriverName = "";
                int secondDriverSkill = 0;
                if (driverOne.Name == "Bob")
                {
                    Console.WriteLine("Choose a Driver No.2 with a number:");
                    Console.WriteLine($"1.{greg.Name}\n2.{jill.Name}\n3.{ane.Name}");
                    string driverTwoInput = Console.ReadLine();

                    switch (driverTwoInput)
                    {
                        case "1":
                            secondDriverName = greg.Name;
                            secondDriverSkill = greg.Skill;
                            break;
                        case "2":
                            secondDriverName = jill.Name;
                            secondDriverSkill = jill.Skill;
                            break;
                        case "3":
                            secondDriverName = ane.Name;
                            secondDriverSkill = ane.Skill;
                            break;
                    };
                }

                if (driverOne.Name == "Greg")
                {
                    Console.WriteLine("Choose a Driver No.2 with a number:");

                    Console.WriteLine($"1.{bob.Name}\n2.{jill.Name}\n3.{ane.Name}");
                    string driverTwoInput = Console.ReadLine();
                    switch (driverTwoInput)
                    {
                        case "1":
                            secondDriverName = bob.Name;
                            secondDriverSkill = bob.Skill;
                            break;
                        case "2":
                            secondDriverName = jill.Name;
                            secondDriverSkill = jill.Skill;
                            break;
                        case "3":
                            secondDriverName = ane.Name;
                            secondDriverSkill = ane.Skill;
                            break;
                    };
                }

                if (driverOne.Name == "Jill")
                {
                    Console.WriteLine("Choose a Driver No.2 with a number:");
                    Console.WriteLine($"1.{bob.Name}\n2.{greg.Name}\n3.{ane.Name}");
                    string driverTwoInput = Console.ReadLine();
                    switch (driverTwoInput)
                    {
                        case "1":
                            secondDriverName = bob.Name;
                            secondDriverSkill = bob.Skill;
                            break;
                        case "2":
                            secondDriverName = greg.Name;
                            secondDriverSkill = greg.Skill;
                            break;
                        case "3":
                            secondDriverName = ane.Name;
                            secondDriverSkill = ane.Skill;
                            break;
                    };
                }

                if (driverOne.Name == "Ane")
                {
                    Console.WriteLine("Choose a Driver No.2 with a number:");

                    Console.WriteLine($"1.{bob.Name}\n2.{greg.Name}\n3.{jill.Name}");
                    string driverTwoInput = Console.ReadLine();
                    switch (driverTwoInput)
                    {
                        case "1":
                            secondDriverName = bob.Name;
                            secondDriverSkill = bob.Skill;
                            break;
                        case "2":
                            secondDriverName = greg.Name;
                            secondDriverSkill = greg.Skill;
                            break;
                        case "3":
                            secondDriverName = jill.Name;
                            secondDriverSkill = jill.Skill;
                            break;
                    };
                }

                Car secondCar = new Car(secondCarModel, secondCarSpeed);
                Driver secondDriver = new Driver(secondDriverName, secondDriverSkill);
                secondCar.Driver = secondDriver;

                racingMethods.RaceMethod(carOne, secondCar);

                Console.WriteLine("\nIf you want to race again enter \nyes, \nif you want to end the game enter \nno");
                string userAnswer = Console.ReadLine().ToLower();
                Console.WriteLine("\n");

                if (userAnswer == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
