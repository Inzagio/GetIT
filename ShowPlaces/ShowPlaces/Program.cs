using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowPlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var place = new Place("Stavern", "Larvik", "Vestfold");
            var place2 = new Place("Frei", "Kristiansund", "Møre og Romsdal");

            place.ShowPlace();
            place2.ShowPlace();
        }
    }
}
