using System.Collections.Generic;
using System.IO;

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
                string line = string.Empty;
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            return list;
        }
    }  
}
