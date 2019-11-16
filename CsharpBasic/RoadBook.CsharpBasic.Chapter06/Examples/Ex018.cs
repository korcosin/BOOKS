using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex018
    {
        public void Run()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("korea", "한국");
            dict.Add("japan", "일본");
            dict.Add("brazil", "브라질");
            dict.Add("china", "중국");
            dict.Add("canada", "캐나다");
            dict.Add("america", "미국");
            dict.Add("spain", "스페인");

            while (true)
            {
                Console.Write("단어를 입력하세요(Q:종료) : ");
                string word = Console.ReadLine().ToLower();

                if (word == "q")
                {
                    break;
                }

                if (dict.ContainsKey(word))
                {
                    Console.WriteLine("{0} : {1}", word, dict[word]);

                    Console.Write("단어를 삭제할까요?(Y:삭제 / N:미삭제) : ");
                    string deleteYN = Console.ReadLine();

                    if (deleteYN.ToUpper() == "Y")
                    {
                        dict.Remove(word);
                    }
                }
                else
                {
                    Console.Write("단어 검색결과가 없습니다. 사전에 추가할까요? (Y:추가 / N:미추가) : ");
                    string addYN = Console.ReadLine();

                    if (addYN.ToUpper() == "Y")
                    {
                        Console.Write("뜻을 입력하세요 : ");
                        string value = Console.ReadLine();

                        dict.Add(word, value);
                    }
                }
            }
        }
    }
}