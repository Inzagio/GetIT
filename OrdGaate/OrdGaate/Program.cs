using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace OrdGaate
{
    class Program
    {
        private static readonly Random rnd = new Random();

        static void Main()
        {
          
            var list = GetList();
            foreach (var words in list)
            {
                if (words.Length > 7 && words.Length <= 10 && !words.Contains('-'))
                {
                    //Console.WriteLine(words);
                }
                
            }

            FindRandomWord(GetList());
        }


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

        private static void FindRandomWord(string[] allLines)
        {
            var randomWord = allLines[rnd.Next(0, allLines.Length)];
            Console.WriteLine(randomWord);
        }
    }
}
