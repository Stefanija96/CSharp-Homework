using Models.Classes;
using System;
using Models.Enums;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------ELECTRIC CAR----------");

            int id =0;
            ElectricCar electricCar = new ElectricCar(id,"Alfa Romeo","Disco Volante", 2, 220, Consumption.Economic, 100, 45);

            Console.WriteLine(electricCar.PrintInfo());
            electricCar.Drive(1086);
            electricCar.Recharge(20);

            Console.WriteLine("----------FUEL CAR----------");

            FuelCar fuelCar = new FuelCar(id, "McLaren", "720S", 3, 300, Consumption.High, EngineType.Diesel, 100, 67);

            Console.WriteLine(fuelCar.PrintInfo());
            fuelCar.Drive(1000);
            fuelCar.Refuel(65);
        }
    }
}
