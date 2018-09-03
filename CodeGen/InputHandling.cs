using System;
using System.Text;

namespace CodeGen
{
    class InputHandling
    {
        public static void ReadInput(string[] args)
        {

            int toInt32 = Convert.ToInt32(args[0]);
            var pattern = new StringBuilder(args[1].PadRight(toInt32, 'l'));

            var password = new StringBuilder(string.Empty);
            using(var progress = new ProgressBar())
            while (pattern.Length > 0)
            {
                var patternPosition = Checks.Random.Next(0, pattern.Length - 1);
                progress.Report(1 - (double)pattern.Length / toInt32);
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
