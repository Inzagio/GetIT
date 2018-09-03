using System;

using System.Diagnostics;

namespace CodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No args present" + Environment.NewLine);
                OutputHandling.ShowHelpText();
                Console.Write("Input password length and pattern: ");
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
            if (!Validation.IsValid(args))
            {
                OutputHandling.ShowHelpText();
                return;
            }
            stopwatch.Start();
            InputHandling.ReadInput(args);
            stopwatch.Stop();
            Console.WriteLine("\n\rTime elapsed: {0}ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\n\rPress any key to exit. Do you know where it is?");
            Console.ReadKey();
        }










    }
}

