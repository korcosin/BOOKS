using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex002
    {
        public void Run()
        {
            List<string> strList = new List<string>();

            strList.Add("HI");
            Console.WriteLine(strList[0]);

            strList.Clear();
            Console.WriteLine(strList[0]);
        }
    }
}