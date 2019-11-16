using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex004
    {
        public void Run()
        {
            // step1> 배열 선언과 동시에 초기화
            string[] days = { "sunny", "sunny", "rainy", "cloudy", "rainy", "snow", "sunny" };

            // step2> 배열 가져오기
            int dayCnt = days.Length;

            int sunnyCnt = 0;
            int cloudyCnt = 0;
            int rainyCnt = 0;
            int snowCnt = 0;

            for (int idx = 0; idx < dayCnt; idx++)
            {
                string weather = days[idx];

                if (weather == "sunny") sunnyCnt++;
                if (weather == "cloudy") cloudyCnt++;
                if (weather == "rainy") rainyCnt++;
                if (weather == "snow") snowCnt++;
            }

            Console.WriteLine("맑음 : {0} / 흐림 : {1} / 비 : {2}, 눈 : {3}", 
                sunnyCnt, cloudyCnt, rainyCnt, snowCnt);
        }
    }
}