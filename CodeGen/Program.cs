using System;

using System.Diagnostics;
using System.Text;


namespace CodeGen
{
    class Program
    {
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            
            if (args.Length == 0)
            {
                Console.WriteLine("No args present" + Environment.NewLine);
                ShowHelpText();
                Console.Write("Input password length: "); 
                args = Console.ReadLine()?.Split(' ');

                //string input = "";
                //while (true)
                //{
                //    var key = Console.ReadKey();
                //    if (key.Key == ConsoleKey.Enter)
                //    {
                //        break;                        
                //    }

                //    input += key.KeyChar;

                //}
            }
            Stopwatch stopwatch = new Stopwatch();
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }

          

            stopwatch.Start();
            ReadInput(args);
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Time elapsed: {0}ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit. Do you know where it is?");
            Console.ReadKey();
        }



        private static bool IsValid(string[] args)
        {
            return args.Length == 2 && CheckNumber(args[0]) && CheckOptions(args[1]);

        }

        private static bool CheckNumber(string s)
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

        private static bool CheckOptions(string s)
        {
            foreach (var c in s)
            {
                switch (c)
                {
                    case 'l':
                        break;
                    case 'L':
                        break;
                    case 's':
                        break;
                    case 'd':
                        break;
                    default: return false;
                }
            }

            return true;
        }

        private static void ReadInput(string[] args)
        {
          
            var pattern = new StringBuilder(args[1].PadRight(Convert.ToInt32(args[0]), 'l'));
            
            var password = new StringBuilder(string.Empty);
            while (pattern.Length > 0)
            {
                var patternPosition = pattern.Length - 1;

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
            Console.WriteLine();
            //Console.WriteLine(password);
            WriteToFile.SaveToFile(password.ToString());
        }

   
        static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max);
        }

        private static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z');
        }

        private static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        private static char WriteRandomSpecialCharacter()
        {
            var specialChars = "(!\"#¤%&/(){}[]";
            return specialChars[Random.Next(0, specialChars.Length - 1)];
        }

        private static int WriteRandomDigit()
        {
            return Random.Next(5, 15);
        }

        private static void ShowHelpText()
        {
            Console.WriteLine(
                "PasswordGenerator  \r\n  Options:\r\n  - l = lower case letter\r\n  - L = upper case letter\r\n  - d = digit\r\n  - s = special character (!\"#¤%&/(){}[]\r\nExample: PasswordGenerator 14 lLssdd\r\n         Min. 1 lower case\r\n         Min. 1 upper case\r\n         Min. 2 special characters\r\n         Min. 2 digits");
        }
    }
}

