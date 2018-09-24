using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLinqTasks
{
    class Readfile
    {
        public static List<string> ReadFile()
        {
            var list = new List<string>();
            var filepath = @"..\..\Resources\startlist.csv";
            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line.Split(',');
                    list.Add(line);
                }
            }
            return list;
        }
    }
}
