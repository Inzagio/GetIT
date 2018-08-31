using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeGen
{
    class WriteToFile
    {
        public static void SaveToFile(string password)
        {
            var dir = @"C:\Users\TrymKBjørnvik\Documents\Test\password.txt";
            File.WriteAllText(dir, password + Environment.NewLine);
            Console.WriteLine();
            Console.WriteLine("Password saved to " + dir );
        }
    }
}
