using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPuzzle_nb_NO
{
    class Program
    {
        private static readonly Random Rnd = new Random();

        public static void Main(string[] args)
        {
            var filepath = args.Length != 0 ? args[0] : "Resources\\Ordliste.txt";
            var resourceFile = ReadFile.ReadFromFile(filepath);
            var test = GetWords(resourceFile);
            string lastPart;
            FindRandomWord(out lastPart,test);
            for (int i = 0; i < 100; i++)
            {
                
            var test2 = FindRandomWord(out lastPart,test);
            }

            DisplayList(test2);


        }

        private static string[] GetWords(string[] resourceFile)
        {
            var dictionary = new List<string>();
            foreach (var word in resourceFile)
            {
                if (word.Length > 7 && word.Length <= 10 && !word.Contains('-'))
                {
                    dictionary.Add(word);
                }
            }
            return dictionary.ToArray();
        }

        public static string FindRandomWord(out string lastPart,  string[] dictionaryFull)
        {
            var randomWord = dictionaryFull[Rnd.Next(0, dictionaryFull.Length)];

            lastPart = randomWord.Substring(randomWord.Length - 3);
            return randomWord;
           
        }
        private static string DisplayList(string lastPart, string[] dictionaryFull)
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
                randomWord = FindRandomWord(out lastPart, list);
            foreach (var word in list)
            {
                if (word.Substring(0, lastPart.Length - 1) == lastPart)
                {
                    stretchingYogaWord = word;
                }
            }

           return stretchingYogaWord;
        }
    }
}
