using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex011
    {
        public void Run()
        {
            Hashtable hst = new Hashtable();
            hst.Add("korea", "한국");
            hst.Add("japan", "일본");
            hst.Add("brazil", "브라질");
            hst.Add("china", "중국");
            hst.Add("canada", "캐나다");
            hst.Add("america", "미국");
            hst.Add("spain", "스페인");

            Console.Write("단어를 입력하세요 : ");
            string word = Console.ReadLine();

            if (hst.Contains(word))
            {
                Console.WriteLine("{0} : {1}", word, hst[word]);
            }
            else
            {
                Console.WriteLine("단어 검색결과가 없습니다.");
            }
        }
    }
}