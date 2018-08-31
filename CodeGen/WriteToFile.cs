using System;
using System.IO;
using System.Reflection;



namespace CodeGen
{
    class WriteToFile
    {
        public static void SaveToFile(string password)
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\password.txt";
            File.WriteAllText(dir, password + Environment.NewLine);
            Console.WriteLine();
            Console.WriteLine("Password saved to " + dir);
        }
    }
}
