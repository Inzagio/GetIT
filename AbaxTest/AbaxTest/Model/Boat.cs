using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxTest
{
    public class Boat : Vehicle
    { 
        public decimal GrossTonnage { get; }

        public Boat(string regNr, int power, int topSpeed, decimal grossTonnage) : base(regNr, power, topSpeed, null)
        {
            GrossTonnage = grossTonnage;
            Units.Add(nameof(GrossTonnage), "Gt");
            Units[nameof(topSpeed)] = "knots";
        }

        public override void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(GrossTonnage), GrossTonnage);
        }
    }
}
