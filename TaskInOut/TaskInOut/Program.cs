using System;
using System.Linq;

namespace TaskInOut
{
    class Program
    {   static Random scramble = new Random();
        static char[] alpha =  "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static char[] second = alpha.OrderBy(x=>scramble.Next()).ToArray();
        
        public static void Main(string[] args)
        {
            // var intArray = new int[6];
            //int[] intArray = { 1, 2, 3, 4, 5,94,1 };
            //Console.WriteLine(IsArraySorted.isArraySorted(intArray));
            string plaintext = "Ibsens Ripsbaerbusker og andre buksvekster.";
            Console.WriteLine(ChiperArray(plaintext));
            Console.WriteLine(DechiperArray(ChiperArray(plaintext)));
        }

        public static string ChiperArray(string plainText)
        {
            plainText = plainText.ToUpper();
            var outputText = string.Empty;
            foreach (var character in plainText)
            {
                if (alpha.Contains(character))
                {
                    //var index = Array.IndexOf(second, character);
                    var text = second[Array.IndexOf(alpha, character)];
                    if (text == character)
                    {
                        
                    }
                        outputText += text;


                }
                else
                {
                    outputText += character;
                }
            }


            return outputText;
        }
        public static string DechiperArray(string plainText)
        {

            plainText = plainText.ToUpper();
            var outputText = string.Empty;
            foreach (var character in plainText)
            {
                if (second.Contains(character))
                {
                    //var index = Array.IndexOf(second, character);
                    outputText += alpha[Array.IndexOf(second, character)];
                }
                else
                {
                    outputText += character;
                }
            }


            return outputText;
        }



    }

}
