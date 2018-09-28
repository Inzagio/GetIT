using System;
using System.IO;

namespace Persistens
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "program.data";
            var count = 0;
            var fileInfo = new FileInfo(fileName);
            if (fileInfo.Exists)
            {
                count = Convert.ToInt32(File.ReadAllText(fileName));
            }

            count++;
            Console.WriteLine($"Dette er {count} gang du kjører programmet");
            File.WriteAllText(fileName, count.ToString());
        }
    }
}
