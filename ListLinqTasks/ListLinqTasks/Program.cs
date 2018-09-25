using System.Linq;

namespace ListLinqTasks
{
    class Program
    {

        static void Main(string[] args)
        {
            var output = new Output("startlist.txt");
            // var oldOut = Console.Out;
            //  var writer = new StreamWriter("startlist.txt");
            // Console.SetOut(writer);
            output.WriteLine("                         Startliste Ritt");
            output.WriteLine();
            var data = new AnalyseData();
            //var bigData = data.DataAnalysis().OrderByDescending(w => w.clubList.Count).ThenBy(w => w.Name);
            var bigData = from dataSet in data.DataAnalysis()
                          orderby dataSet.clubList.Count descending, dataSet.Name
                          select dataSet;
            foreach (var word in bigData)
            {
                output.WriteLine($"Startnr  Navn            Klubb                             Klasse");
                output.WriteLine("_____________________________________________________________________");
                foreach (var c in word.clubList)
                {
                    output.WriteLine(c.GetString());
                }
                output.WriteLine("_____________________________________________________________________");
                output.WriteLine();
            }
            //Console.SetOut(oldOut);
            //writer.Close();
        }
    }
}
