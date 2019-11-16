using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam005
    {
        public void Run()
        {
            List<string> strList = new List<string>() { "Dexter", "Julie", "Jeffrey", "Bree", "Sven" };

            strList.Add("Clint");
            strList.Contains("Dexter");
            strList.Insert(2, "Ellin");
            strList.RemoveAt(3);
            int strListCount = strList.Count;
            strList.Clear();
            strList.Add("Dexter");
            strList.Add("Julie");
            strList.Add("Ellin");
            strList.Add("Jeffrey");
            strList.Add("Khan");
            strList.Add("Pil");
            strList.RemoveRange(5, 2);
        }
    }
}