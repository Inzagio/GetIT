using System;
using System.Collections.Generic;


namespace ListLinqTasks
{
   class AnalyseData
    {
    //    private List list;

    //    public AnalyseData(List<string> list)
    //    {
    //        this.list = list;
    //    }

    public List<string> DataAnalysis()
    {
        var result = new List<string>();
        List<string> dummyData = Readfile.ReadFile();

        foreach (var word in dummyData)
        {
            word.Split(',');
            result.Add(word);
        }

        return result;
    }
}
}
