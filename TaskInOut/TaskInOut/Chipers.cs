using System;
using System.Linq;
using static System.Array;

namespace TaskInOut
{
    class Chipers
    {
        private static Random scramble = new Random();
        private static readonly char[] Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static char[] chiperKey = ScrambleProperly();

        public static string ChiperArray(string plainText)
        {
            plainText = plainText.ToUpper();
            var outputText = string.Empty;
            foreach (var character in plainText)
            {
                if (Alpha.Contains(character))
                {
                    //var index = Array.IndexOf(chiperKey, character);
                    var text = chiperKey[IndexOf(Alpha, character)];
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
                if (chiperKey.Contains(character))
                {
                    //var index = Array.IndexOf(chiperKey, character);
                    outputText += Alpha[IndexOf(chiperKey, character)];
                }
                else
                {
                    outputText += character;
                }
            }


            return outputText;
        }

        public static char[] ScrambleProperly()
        {
            char[] outArr = Alpha.Clone() as char[];
            for (int i = 0; i < Alpha.Length; i++)
            {
                if (Alpha[i] == outArr[i])
                {
                    var fromArr = outArr[i];
                    var randomDigit = scramble.Next(Alpha.Length - 1);
                    while (randomDigit == i)
                    {
                        randomDigit = scramble.Next(Alpha.Length - 1);
                    }

                    outArr[i] = outArr[randomDigit];
                    outArr[randomDigit] = fromArr;
                }
            }
            return outArr;
        }
    }
}