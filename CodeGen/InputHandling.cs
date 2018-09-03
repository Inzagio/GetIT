using System;
using System.Text;

namespace CodeGen
{
    class InputHandling
    {
        public static void ReadInput(string[] args)
        {

            var pattern = new StringBuilder(args[1].PadRight(Convert.ToInt32(args[0]), 'l'));

            var password = new StringBuilder(string.Empty);
            while (pattern.Length > 0)
            {

                var patternPosition = Checks.Random.Next(0, pattern.Length - 1);

                switch (pattern[patternPosition])
                {
                    case 'l':
                        password.Append(Checks.WriteRandomLowerCaseLetter());
                        break;
                    case 'L':
                        password.Append(Checks.WriteRandomUpperCaseLetter());
                        break;
                    case 's':
                        password.Append(Checks.WriteRandomSpecialCharacter());
                        break;
                    case 'd':
                        password.Append(Checks.WriteRandomDigit());
                        break;
                    default:
                        return;
                }

                pattern = pattern.Remove(patternPosition, 1);
            }
            Console.WriteLine();
            // Console.WriteLine(password);
            WriteToFile.SaveToFile(password.ToString());
        }
    }
}
