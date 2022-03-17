using System;
using System.Collections.Generic;
using System.Text;

namespace Class_TASK_Class
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int MaxSpeed;


        public Car(string brand, string model, string color, int max):this()
        {
            Brand = brand;
            Model = model;
            Colour = color;
            MaxSpeed = max;
        }

        public virtual void GetInfo() 
        {
            Console.WriteLine($"Brand: {Brand},Model:{Model},Colour:{Colour},Maxspeed:{MaxSpeed}");
        
        }

        public Car()
        {
            Console.WriteLine("carcreated");
        }     
    }
}
