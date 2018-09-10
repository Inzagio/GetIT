using System;
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
            
            var inputFile = File.ReadLines(path, Encoding.UTF8);
            foreach (var line in inputFile)
            {
                var parts = line.Split('\t');
                var word = parts[1];
                //Console.WriteLine(word);
                if (word.Length != word.Distinct().Count())
                {
                    Console.WriteLine(word);
                }

            }

        }
    }
}
