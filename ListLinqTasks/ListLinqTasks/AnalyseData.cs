using System;
using System.Collections.Generic;
using System.Linq;


namespace ListLinqTasks
{
   class AnalyseData
    {


    public List<Club> DataAnalysis()
    {
        var result = new List<Club>();
        List<string> data = Readfile.ReadFile();
        foreach (var line in data)
        {
            var splitted = line.Split(',');
            var startNumber = splitted[0].Trim('"');
            var name = splitted[1].Trim('"');
            var club = splitted[2].Trim('"');
            var nationality = splitted[3].Trim('"');
            var group = splitted[4].Trim('"');
            var @class = splitted[5].Trim('"');
            if (string.IsNullOrEmpty(club)|| club == ".")
            {
                club = "Ingen Klubb";
            }
            var registration = new Registration(startNumber,name,club,nationality,@group,@class);
            var clubs = result.FirstOrDefault(w => string.Equals(w.Name, club, StringComparison.CurrentCultureIgnoreCase)) ;
            if (clubs == null)
            {
                clubs = new Club(club);
                result.Add(clubs);
            }
            clubs.AddToClubList(registration);
        }

        return result;
    }

}
}
