using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrdGaate
{
    class ReadInputs
    {
        public static string[] ReadInput(string filePath)
        {
            var dictionary = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {

                string line;
                while ((line = reader.ReadLine())!=null)
                {
                    var words = line.Split('\t')[1];
                    dictionary.Add(words.ToLower());
                }

            }
            return dictionary.Distinct().ToArray();
        }
    }
}