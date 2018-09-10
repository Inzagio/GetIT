using System;
using System.Diagnostics;
using static System.Console;
/*This is a program for generating a password, save it to a file
 *File will be overwritten when saving a password
 *Takes two cmd args and randomizes a password string from preferences
 */
namespace CodeGen
{
    class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine(@"No args present" + Environment.NewLine);
                OutputHandling.ShowHelpText();
                Write(@"Input password length and pattern: ");
                args = ReadLine()?.Split(' ');
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
            if (!Validation.IsValid(args))
            {
                OutputHandling.ShowHelpText();
                return;

            }
            stopwatch.Start();
            InputHandling.ReadInput(args);
            stopwatch.Stop();
            
            WriteLine("\n\rTime elapsed: {0}ms", stopwatch.ElapsedMilliseconds);
            WriteLine("\n\rPress any key to exit. Do you know where it is?");
            ReadKey();
        }

    }
}

