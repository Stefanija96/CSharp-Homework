using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Classes
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }
        

        public ElectricCar(int id, string brand, string model, int doors, int topSpeed, Consumption consumption, int batteryCapacity, int batteryUsage)
            : base(id,brand, model, doors, topSpeed, consumption, EngineType.Electric)
        {
            BatteryCapacity = batteryCapacity;
            BatteryUsage = batteryUsage;
        }
        public void Drive(int distance)
        {
            int bateryUsed = 0;
            if (Consumption == Consumption.Economic)
                bateryUsed = (distance * 1) / 10;
            if (Consumption == Consumption.Medium)
                bateryUsed = (distance * 2) / 10;
            if (Consumption == Consumption.High)
                bateryUsed = (distance * 3) / 10;
            int used = (bateryUsed * 100) / BatteryCapacity;
            if (used >= 100)
            {
                Console.WriteLine($"I'm sorry, you have used the total ammount of energy of this car.");

            }
            else if (used < 100)
            {
                Console.WriteLine($"You have left {BatteryUsage-BatteryCapacity}%");
            }
        }
        public void Recharge(int minutes){

            int lastDigitOfMinutes = minutes % 10;
            int minutesRounded = minutes - lastDigitOfMinutes;
            int minutesForChargingLeft = (BatteryCapacity - BatteryUsage) * 10;
            if (minutesForChargingLeft < minutes)
                Console.WriteLine($"Can't charge longer than {minutesForChargingLeft} minutes");
            else
            {
                while (minutesRounded > 0 && BatteryUsage < 100)
                {
                    BatteryUsage++;
                    minutesRounded -= 10;
                }
                Console.WriteLine($"Your car has been charged to {BatteryUsage}%");
            }
        }

    }

}
