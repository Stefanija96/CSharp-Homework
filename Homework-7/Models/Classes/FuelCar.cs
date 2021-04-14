using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace Models.Classes
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public FuelCar(int id, string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType, int fuelCapacity, int currentFuel)
            : base(id, brand, model, doors, topSpeed, consumption, engineType)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
        }

        public void Drive(int distance)
        {
            int fuelUsed = 0;
            if (Consumption == Consumption.Economic)
                fuelUsed = (distance * 1) / 10;
            if (Consumption == Consumption.Medium)
                fuelUsed = (distance * 2) / 10;
            if (Consumption == Consumption.High)
                fuelUsed = (distance * 3) / 10;
            int used = (fuelUsed * 100) / FuelCapacity;
            if (used > 100)
            {
                Console.WriteLine($"I'm sorry, you have used the total ammount of fuel of this car.");
            }
            else if (used < 100)
            {
                Console.WriteLine($"You have left {CurrentFuel} fuel left");
            }
        }
        public void Refuel(int fuel)
        {
            int emptyTankCapacity = FuelCapacity - CurrentFuel;
            if (emptyTankCapacity < fuel)
                Console.WriteLine($"Can't refuel more than {emptyTankCapacity} litres.");
            else
            {
                while (fuel > 0)
                {
                    CurrentFuel++;
                    fuel--;
                }
                Console.WriteLine($"Your car have {CurrentFuel} litters in the tank.");
            }
        }
       
    }
}
