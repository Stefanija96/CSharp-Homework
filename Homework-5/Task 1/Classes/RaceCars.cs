using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Classes
{
   public class RaceCars
    {
        public void RaceMethod(Car firstCar, Car secondCar)
        {

            if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed())
            {
                Console.WriteLine($"Car no. 1 was faster.");
                Console.WriteLine($"{firstCar.Model} won the Race, with speed {firstCar.Speed} km/h, and the driver was {firstCar.Driver.Name}");
            }
            else if(firstCar.CalculateSpeed() < secondCar.CalculateSpeed())
            {
                Console.WriteLine($"Car no. 2 was faster.");
                Console.WriteLine($"{secondCar.Model} won the Race, with speed {secondCar.Speed} km/h, and the driver was {secondCar.Driver.Name}");
            }
            else
            {
                Console.WriteLine( $"{firstCar.Model} driven by {firstCar.Driver.Name} is as fast as {secondCar.Model} driven by {secondCar.Driver.Name}.They were both driving with {firstCar.Speed}km/h so there is no winner!");
            }
        }
    }
}
