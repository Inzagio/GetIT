using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace OrdGaate
{
    class Program
    {
        static void Main(string[] args)
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

            IEnumerable<string> distinctWords = lines.Distinct();
            foreach (string word in distinctWords)
            {
                Console.WriteLine(word);
            }


        }
    }
}
