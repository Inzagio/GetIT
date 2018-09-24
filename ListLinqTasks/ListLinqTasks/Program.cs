using System;
using System.Collections.Generic;

namespace ListLinqTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new AnalyseData();
            var bigData = data.DataAnalysis();
            foreach (var word in bigData)
            {
                Console.WriteLine(word);
            }

        }
    }
}
