using System;

namespace CodeGen
{
    class Checks
    {
        public static readonly Random Random = new Random();


       public static bool CheckNumber(string s)
        {
            foreach (var c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
        static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max);
        }

        public static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z');
        }

        public static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        public static char WriteRandomSpecialCharacter()
        {
            var specialChars = "(!\"#¤%&/(){}[]";
            return specialChars[Random.Next(0, specialChars.Length - 1)];
        }

        public static int WriteRandomDigit()
        {
            return Random.Next(5, 15);
        }
    }
}
