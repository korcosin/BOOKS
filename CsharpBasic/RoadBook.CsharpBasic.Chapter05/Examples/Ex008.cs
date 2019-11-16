using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex008
    {
        public void Run()
        {
            GasolineCar008 gasolineCar = new GasolineCar008();
            gasolineCar.Color = "검정";
            gasolineCar.Size = "SUV";
            ElectronicCar008 electronicCar = new ElectronicCar008();
            electronicCar.Color = "초록";
            electronicCar.Size = "경차";

            Console.WriteLine("{0}색 {1}가", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.Go();
            Console.WriteLine("{0}색 {1}가", electronicCar.Color, electronicCar.Size);
            electronicCar.Left();
        }
    }

    class Car008
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

    class GasolineCar008 : Car008 { }
    class ElectronicCar008 : Car008 { }
}