using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
    {
        /*
         * Input output skjerm/tastatur
         * Input og Output til fil
         *
         * Encoding
         * using - for å dispose filressurser
         * List<string> - ToArray()
         * string.contains
         * string.Length
         * string.Substring
         *
         * random
         */
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 0; i < 1000; i++)
            //Console.Beep(570, 600);
            Console.Beep(150, 700);
            Console.ReadKey();
            }


            //Console.Write("Hei hva heter du?: ");
            //var name = Console.ReadLine();
            //Console.WriteLine("Hei " + name + "!");
        }
    }
}
