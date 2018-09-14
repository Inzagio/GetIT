using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace OrdGaate
{
    class Program
    {
        private static readonly Random Rnd = new Random();

        static void Main(string[] args)
        {
            var filePath = args.Length != 0 ? args[0] : "Ordliste.txt";

            var completeDictionary = ReadInputs.ReadInput(filePath);

            var dictionary = CheckLengthDictionary(completeDictionary);
         

        }

        public static string[] CheckLengthDictionary(string[] completeDictionary)
        {
            var dictionary = new List<string>();
            foreach (var words in dictionary)
            {
                if (words.Length > 7 && words.Length <= 10 && !words.Contains('-'))
                {
                    dictionary.Add(words);
                }
            }
            return dictionary.ToArray();
        }





       

        //static void Main(string[] args)
        //{
        //    DisplayList();
        //}

        private static void DisplayList(string lastPart, string[] dictionaryFull)
        {
            var list = dictionaryFull;
            //foreach (var words in list)
            //{
            //    if (words.Length > 7 && words.Length <= 10 && !words.Contains('-'))
            //    {
            //        var word = words;
            //    }
            //}

            var stretchingYogaWord = string.Empty;

            string randomWord = string.Empty;
            while (!(randomWord.Length > 7 && randomWord.Length <= 10 && !randomWord.Contains('-')))
                randomWord = FindRandomWord(list);
            foreach (var word in list)
            {
                if (word.Substring(0, lastPart.Length -1) == lastPart)
                {
                    stretchingYogaWord = word;
                }
            }

            Console.WriteLine(stretchingYogaWord);
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
                    var word = reader.ReadLine()?.Split('\t')[1];

                    lines.Add(word);
                }

            }

            var dictionaryFull = lines.Distinct().ToArray();
            return dictionaryFull;
        }

        private static string FindRandomWord(string[] dictionaryFull)
        {
            var randomWord = dictionaryFull[Rnd.Next(0, dictionaryFull.Length)];

            var lastPart = randomWord.Substring(randomWord.Length - 3);
            return randomWord;
            //Console.WriteLine(randomWord);
            //Console.WriteLine(lastPartFirstWord);
        }
    }
}