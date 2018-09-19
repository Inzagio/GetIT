using System;
using static System.Console;
using static System.Convert;

namespace BottleFillingSimulation
{
    class Program
    {


        static void Main(string[] args)
        {
            WriteLine("Specify wanted bottle size for Bottle Nr 1: ");
            var bottle1 = new Bottle(0) {Capacity = ToInt32(ReadLine())};

            WriteLine("Specify wanted bottle size for Bottle Nr 2: ");
            var bottle2 = new Bottle(0) {Capacity = ToInt32(ReadLine())};

            WriteLine("Wanted volume?:");
            int wantedVolume = ToInt32(ReadLine()); ;
            int numberOfOperations = 1;
            while (true)
            {
                TryWithGivenNumberOfOperations(numberOfOperations, bottle1, bottle2, wantedVolume);
                numberOfOperations++;
            }

        }

        private static void TryWithGivenNumberOfOperations(int numberOfOperations, Bottle bottle1, Bottle bottle2, int wantedVolume)
        {
            WriteLine("Running with " + numberOfOperations + " operations.");
            var operations = new int[numberOfOperations];
            while (true)
            {
                DoOperations(operations, bottle1, bottle2);
                CheckIfSolvedAndExitApplicationIfSo(bottle1, bottle2, wantedVolume, operations);
                var success = UpdateOperations(operations);
                if (!success) break;
            }
        }

        private static void CheckIfSolvedAndExitApplicationIfSo(Bottle bottle1, Bottle bottle2, int wantedVolume, int[] operations)
        {
            if (bottle1.Content == wantedVolume || bottle2.Content == wantedVolume)
            {
                WriteLine("Solution:");
                ShowOperations(operations, bottle1);
                Environment.Exit(0);
            }


        }

        private static void ShowOperations(int[] operations, Bottle bottle1)
        {
            var texts = new[]
            {
                $"Fill  bottle 1 from tap",
                "Fill  bottle 2 from tap",
                "Empty bottle 1 to bottle 2",
                "Empty bottle 2 to bottle 1",
                "Fill bottle  2 with bottle 1",
                "Fill bottle 1 with bottle 2",
                "Empty bottle 1 (throw remainder)",
                "Empty bottle 2 (throw remainder)",
            };
            foreach (var operation in operations)
            {
                WriteLine(" " + texts[operation]);
            }

        }

        public static void DoOperations(int[] operations, Bottle bottle1, Bottle bottle2)
        {
            bottle1.Empty();
            bottle2.Empty();
            foreach (var operation in operations)
            {

                if (operation == 0) bottle1.FillFromTap();
                else if (operation == 1) bottle2.FillFromTap();
                else if (operation == 2)
                {
                    if (bottle1.IsEmpty()) break;
                    var success = bottle2.Fill(bottle1.Empty());
                    if (!success) break;
                }
                else if (operation == 3)
                {
                    if (bottle2.IsEmpty()) break;
                    var success = bottle1.Fill(bottle2.Empty());
                    if (!success) break;
                }
                else if (operation == 4)
                {
                    var success = bottle2.FillToTop(bottle1);
                    if (!success) break;
                }
                else if (operation == 5)
                {
                    var success = bottle1.FillToTop(bottle2);
                    if (!success) break;
                }
                else if (operation == 6)
                {
                    bottle1.Empty();
                }
                else if (operation == 7)
                {
                    bottle2.Empty();
                }
            }
        }

        public static bool UpdateOperations(int[] operations)
        {
            int i;
            for (i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] < 8)
                {
                    operations[i]++;
                    break;
                }
                operations[i] = 0;
            }
            return i != -1;
        }
    }
}
