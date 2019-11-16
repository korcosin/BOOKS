using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex001
    {
        public void Run()
        {
            const int number = 2;
            int index = 1;

            for (;;)
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);

                break;
            }
        }
    }
}