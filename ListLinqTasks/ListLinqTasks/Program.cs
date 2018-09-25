using System.Linq;

namespace ListLinqTasks
{
    class Program
    {

        static void Main(string[] args)
        {
            var output = new Output("startlist.txt");
            output.WriteLine("                         Startliste Ritt");
            output.WriteLine(string.Empty);
            ShowData(output);
        }

        private static void ShowData(Output output)
        {
            var data = new AnalyseData();
            var bigData = from dataSet in data.DataAnalysis()
                          orderby dataSet.ClubList.Count descending, dataSet.Name
                          select dataSet;
            foreach (var word in bigData)
            {
                output.WriteLine($"StarNr  Navn            Klubb                             Klasse");
                output.WriteLine("_____________________________________________________________________");
                foreach (var c in word.ClubList)
                {
                    output.WriteLine(c.GetString());
                }
                output.WriteLine("_____________________________________________________________________");
                output.WriteLine(string.Empty);
            }
        }
    }
}
