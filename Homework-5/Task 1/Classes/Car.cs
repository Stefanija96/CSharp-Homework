using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public  Driver Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
           
        }
        public int CalculateSpeed()
        {
           int result= Driver.Skill * Speed;
            return result;
           
        }
     
      
    }
   
}
