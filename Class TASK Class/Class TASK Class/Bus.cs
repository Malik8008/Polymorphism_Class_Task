using System;
using System.Collections.Generic;
using System.Text;

namespace Class_TASK_Class
{
    class Bus:Car
    {
        public byte Passangercount;
        public Bus(byte passanger,string brand, string model, string color, int max):base(brand,model,color,max)
        {
            Passangercount = passanger;            
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Passanger:{Passangercount},Brand: {Brand},Model:{Model},Colour:{Colour},Maxspeed:{MaxSpeed}");

        }
    }
}
