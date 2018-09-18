using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleFillingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bottle1 = new Bottle(5);
            var bottle2 = new Bottle(7);
            var wantedVolume = 5;
            var numberOfOperations = 1;
        }

        private static void DoOperations()
        {
            bottle1.Empty();
            bottle2.Empty();

            foreach (var operation in operations)
            {
                if (operation == 0) bottle1.FillFromTap();         // Fylle flaske 1 fra springen
                else if (operation == 1) bottle2.FillFromTap();    // Fylle flaske 2 fra springen
                else if (operation == 2) bottle2.Fill(bottle1.Empty()); // Tømme flaske 1 i flaske 2 - 
                // Tanken er at Empty() returnerer hvor mye det var i flasken før den ble tømt
                else if (operation == 3) bottle1.Fill(bottle2.Empty()); // Tømme flaske 2 i flaske 1
                else if (operation == 4) bottle2.FillToTop(bottle1);    // Fylle opp flaske 2 med flaske 1
                // Tanken er at FillToTop tar en annen Bottle som parameter. Hvis det er nok, fyller den 
                // bottle2 og reduserer bottle1 tilsvarende. Hvis ikke gjør den ingenting.
                else if (operation == 5) bottle1.FillToTop(bottle2);    // Fylle opp flaske 1 med flaske 2
                else if (operation == 6) bottle1.Empty();               // Tømme flaske 1 (kaste vannet)
                else if (operation == 7) bottle2.Empty();
            }
          
        }
    }
}
