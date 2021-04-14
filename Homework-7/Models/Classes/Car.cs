using Models.Enums;
using System;



namespace Models.Classes
{
    public class Car
    {
        public int ID = new Random().Next(1, 99);
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }


        public Car(int Id, string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType)
        {
            ID = new Random().Next(1, 99);
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
            EngineType = engineType;
        }

        public string PrintInfo()
        {
            return $"Car ID: {ID}, Car Brand: {Brand}, Car Model: {Model}, Doors: {Doors}, Top Speed: {TopSpeed}, Consumption {Consumption}, Engine Type: {EngineType}";

        }
  
    }
}
