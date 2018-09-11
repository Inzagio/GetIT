using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace OrdGaate
{
    class Program
    {
        static void Main()
        {
            var list = GetList();
            foreach (var words in list)
            {
                if (words.Length > 7)
                {
                    Console.WriteLine(words);
                }
            }
        }

        //private static string DisplayWords()
        //{
        //    List<string> lines = GetList();
        //    var allWords = string.Empty;
        //    IEnumerable<string> distinctWords = lines.Distinct();
        //    foreach (string words in distinctWords)
        //    {
        //        allWords = words;

        //    }
        //    Console.WriteLine(allWords);
        //    return allWords;
        //}

        public static string[] GetList()
        {
            string path = "Ordliste.txt";
            List<string> lines = new List<string>();
            var reader = new StreamReader(path);
            using (reader)
            {
                while (reader.Peek() >= 0)
                {
                    lines.Add(reader.ReadLine()?.Split('\t')[1]);
                }

            }

            var allLines = lines.Distinct().ToArray();
            return allLines;
        }
    }
}
