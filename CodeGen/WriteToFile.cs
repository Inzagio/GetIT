using static System.Console;
using static System.Environment;
using static System.IO.File;
using static System.IO.Path;
using static System.Reflection.Assembly;


namespace CodeGen
{
    class WriteToFile
    {
        public static void SaveToFile(string password)
        {
            var dir = GetDirectoryName(GetExecutingAssembly().Location) + @"\password.txt";
            WriteAllText(dir, password + NewLine);
            WriteLine();
            WriteLine("Password saved to " + dir);
        }
    }
}
