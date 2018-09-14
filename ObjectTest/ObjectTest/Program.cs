using System;

namespace ObjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Demo1();
            string bigWord = "atomabsorpsjonsspektrofotometer";
            Console.WriteLine(bigWord.Length);
        }

        private static void Demo1()
        {
            var a = new Box
            {
                Width = 20,
                Height = 30
            };

            var b = new Box
            {
                Width = 5,
                Height = 7
            };
            var c = a;
            c.Height = 99;

        }
    }
}
