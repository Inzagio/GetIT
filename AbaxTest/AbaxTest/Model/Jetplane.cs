using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AbaxTest
{
    public class Jetplane : Vehicle
    {
        public decimal Wingspan { get; }
        public decimal LoadCap { get; }
        public decimal Deadweight { get; }


        public Jetplane(string regNr, decimal power,  decimal wingspan, decimal loadCap, decimal deadweight, VehicleType? type) : base(regNr, power, null, type)
        {
            Wingspan = wingspan;
            LoadCap = loadCap;
            Deadweight = deadweight;
            Units.Add(nameof(Wingspan), "meters");
            Units.Add(nameof(LoadCap), "ton");
            Units.Add(nameof(Deadweight), "ton");

        }

        public void StartPlane()
        {
            Console.WriteLine(nameof(Jetplane) + " " + RegNr + " Taxing to runway.");
            Console.WriteLine();
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Wingspan), Wingspan);
            Add(text, nameof(LoadCap), LoadCap);
            Add(text, nameof(Deadweight), Deadweight);
        }
    }
}
