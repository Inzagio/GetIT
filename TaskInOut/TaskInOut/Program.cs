using System.Reflection;
using static System.Console;
using static TaskInOut.Chipers;

namespace TaskInOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            // var intArray = new int[6];
            //int[] intArray = { 1, 2, 3, 4, 5,94,1 };
           //Console.WriteLine(IsArraySorted.isArraySorted(intArray));
            string plaintext = "Ibsens Ripsbaerbusker og andre buskvekster.";
            WriteLine(ChiperArray(plaintext));
            WriteLine(DechiperArray(ChiperArray(plaintext)));
            WriteLine(chiperKey);
            var dir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\chiperKey.txt";
            if (chiperKey != null) System.IO.File.WriteAllText(dir, new string(chiperKey));
        }
    }

}
