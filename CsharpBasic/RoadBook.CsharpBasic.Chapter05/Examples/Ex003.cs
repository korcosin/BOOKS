using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex003
    {
        public void Run()
        {
            Car003 car = new Car003();
            car.Size = "세단";
            car.Color = "하얀";

            Console.WriteLine("고객님의 차, {0} {1}이...", car.Color, car.Size);
            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
    }

    class Car003
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public void Engine_on()
        {
            Console.WriteLine("시동을 켭니다.");
        }

        public void Engine_off()
        {
            Console.WriteLine("시동을 끕니다.");
        }

        public void Go()
        {
            Console.WriteLine("전진합니다.");
        }

        public void Back()
        {
            Console.WriteLine("후진합니다.");
        }

        public void Left()
        {
            Console.WriteLine("좌회전합니다.");
        }

        public void Right()
        {
            Console.WriteLine("우회전합니다.");
        }
    }
}