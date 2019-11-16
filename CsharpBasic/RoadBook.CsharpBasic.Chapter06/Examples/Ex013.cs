using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex013
    {
        public void Run()
        {
            List<int> aList = new List<int>();

            for (int idx = 0; idx < 15; idx++)
            {
                aList.Add(idx);
            }

            aList.Insert(5, 100);

            for (int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}",
                    aList[idx], aList[idx].GetType()
                );
            }

            aList.RemoveAt(5);

            for (int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}",
                    aList[idx], aList[idx].GetType()
                );
            }
        }
    }
}