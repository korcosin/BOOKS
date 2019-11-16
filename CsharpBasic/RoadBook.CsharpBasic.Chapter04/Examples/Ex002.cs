using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex002
    {
        public void Run()
        {
            const int number = 2;

            for (int index = 1;;)
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);

                if (index == 9)
                {
                    break;
                }

                index = index + 1;
            }
        }
    }
}