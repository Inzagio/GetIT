using System.Text;
using static System.Console;
using static System.Convert;
using static CodeGen.Checks;

namespace CodeGen
{
    class InputHandling
    {
        public static void ReadInput(string[] args)
        {

            int toInt32 = ToInt32(args[0]);
            var pattern = new StringBuilder(args[1].PadRight(toInt32, 'l'));

            var password = new StringBuilder(string.Empty);
            using(var progress = new ProgressBar())
            while (pattern.Length > 0)
            {
                var patternPosition = Random.Next(0, pattern.Length - 1);
                progress.Report(1 - (double)pattern.Length / toInt32);
                switch (pattern[patternPosition])
                {
                    case 'l':
                        password.Append(WriteRandomLowerCaseLetter());
                        break;
                    case 'L':
                        password.Append(WriteRandomUpperCaseLetter());
                        break;
                    case 's':
                        password.Append(WriteRandomSpecialCharacter());
                        break;
                    case 'd':
                        password.Append(WriteRandomDigit());
                        break;
                    default:
                        return;
                }
                pattern = pattern.Remove(patternPosition, 1);
            }
            WriteLine();
            // Console.WriteLine(password);
            WriteToFile.SaveToFile(password.ToString());
        }
    }
}
