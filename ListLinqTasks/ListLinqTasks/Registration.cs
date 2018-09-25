using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLinqTasks
{
    class Registration
    {
        public string StartNumber { get; }
        public string Name { get; }
        public string Club { get; }
        public string Nationality { get; }
        public string Group { get; }
        public string Class { get; }

        public Registration(string startNumber, string name, string club, string nationality, string group, string @class)
        {
            StartNumber = startNumber;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = group;
            Class = @class;
        }

        /// <summary>
        /// Method in <see cref="T:Registration"/> for returning. Alternativ to string override.
        /// Returns the object property <see cref="P:StartNumber"/>
        /// <see cref="P:Name"/>
        /// <see cref="P:Club"/>
        /// <see cref="P:Nationality"/>
        /// <see cref="P:Group"/>
        /// <see cref="P:Class"/>
        /// as a string
        /// </summary>
        /// <returns></returns>
        public string GetString() => $"{StartNumber},{Name},{Club},{Nationality},{Group},{Class}";
    }
}
