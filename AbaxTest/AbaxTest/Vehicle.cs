using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxTest
{
    public class Vehicle
    {
        public string RegNr { get;}
        public decimal? TopSpeed { get; }
        public decimal Power { get; }
        public VehicleType? Type { get; }

        protected Dictionary<string, string> Units = new Dictionary<string, string>
        {
            {nameof(Power), "kw" },
            {nameof(TopSpeed), "km/h" }
        };

        public Vehicle(string regNr, decimal power, decimal? topSpeed, VehicleType? type)
        {
            RegNr = regNr;
            Power = power;
            TopSpeed = topSpeed;
            Type = type;
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(GetType().Name);
            Add(text, nameof(RegNr), RegNr);
            Add(text, nameof(TopSpeed), TopSpeed);
            Add(text, nameof(Power), Power);
            ToStringOptional(text);
            return text.ToString();
        }

        protected void Add(StringBuilder text, string name, object value)
        {
            if(value == null) return;
            text.Append("  ");
            text.Append(name);
            text.Append(" = ");
            text.Append(value);
            if (Units.ContainsKey(name)) text.Append(Units[name]);
            text.AppendLine();
        }

        public virtual void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(VehicleType), Type);
        }

       
        public override bool Equals(object obj)
        {
            return Equals(obj as Vehicle);
        }

        private bool Equals(Vehicle vehicle)
        {
            return vehicle != null && GetType() == vehicle.GetType() && RegNr == vehicle.RegNr;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void Compare(Vehicle vehicle2, string prefix)
        {
            var areTheSame = Equals(vehicle2);
            var areTheSameText = areTheSame ? string.Empty : "not ";
            Console.WriteLine(prefix);
            Console.WriteLine("is {0} same vehicle", areTheSameText);
            Console.WriteLine();
        }
    }
}
