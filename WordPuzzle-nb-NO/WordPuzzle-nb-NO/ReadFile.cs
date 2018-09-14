using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WordPuzzle_nb_NO
{
    class ReadFile
    {
        public static string[] ReadFromFile(string filepath)
        {
            var file = new List<string>();
            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line= reader.ReadLine())!=null)
                {
                    var words = line.Split('\t')[1];
                    file.Add(words.ToLower());
                }
            }
                return file.Distinct().ToArray();
        }
    }
}
