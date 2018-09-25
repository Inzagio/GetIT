using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;

namespace ListLinqTasks
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var Console = new Output("startlist.txt");
           // var oldOut = Console.Out;
          //  var writer = new StreamWriter("startlist.txt");
           // Console.SetOut(writer);
            Console.WriteLine("                         Startliste Ritt");
            Console.WriteLine();
            var data = new AnalyseData();
            //var bigData = data.DataAnalysis().OrderByDescending(w => w.clubList.Count).ThenBy(w => w.Name);
            var bigData = from dataSet in data.DataAnalysis()
                orderby dataSet.clubList.Count descending, dataSet.Name
                select dataSet;
            foreach (var word in bigData)
            {
                Console.WriteLine($"Startnr  Navn            Klubb                             Klasse");
                Console.WriteLine("_____________________________________________________________________");
                foreach (var c in word.clubList)
                {
                    Console.WriteLine(c.GetString());
                }
                Console.WriteLine("_____________________________________________________________________");
                Console.WriteLine();
            }
           //Console.SetOut(oldOut);
            //writer.Close();
        }
    }
}
