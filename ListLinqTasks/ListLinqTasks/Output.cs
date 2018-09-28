using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListLinqTasks
{
    class Output
    {
        public StreamWriter Writer { get; }

        public Output(string filename)
        {
            Writer = new StreamWriter(filename);
            
        }
        public void WriteLine(string something)
        {
            Console.WriteLine(something);
            Writer.WriteLine(something);
        }
    }
}
