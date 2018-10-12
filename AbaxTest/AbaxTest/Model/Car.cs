using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AbaxTest
{
    public class Car : Vehicle
    {
        public string Color { get;}

        public Car(string regNr, decimal power, decimal topSpeed, string color, VehicleType type) : base(regNr, power, topSpeed,type)
        {
            Color = color;
        }

        public void Drive()
        {
            Console.WriteLine(nameof(Car)+ " " + RegNr + " has been notified to drive.");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Color), Color);            
        }

    }
}
