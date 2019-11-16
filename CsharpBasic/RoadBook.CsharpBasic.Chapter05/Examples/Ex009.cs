using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex009
    {
        public void Run()
        {
            GasolineCar009 gasolineCar = new GasolineCar009();
            gasolineCar.Color = "검정";
            gasolineCar.Size = "SUV";
            ElectronicCar009 electronicCar = new ElectronicCar009();
            electronicCar.Color = "초록";
            electronicCar.Size = "경차";

            Console.WriteLine("{0}색 {1}가", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.InputGas();
            Console.WriteLine("{0}색 {1}가", electronicCar.Color, electronicCar.Size);
            electronicCar.InputGas();
        }
    }

    class Car009
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

        public virtual void InputGas()
        {
            Console.WriteLine("기름을넣습니다.");
        }
    }

    class GasolineCar009 : Car009
    {
        public override void InputGas()
        {
            Console.WriteLine("휘발유를 넣습니다.");
        }
    }
    class ElectronicCar009 : Car009
    {
        public override void InputGas()
        {
            Console.WriteLine("전기를 넣습니다.");
        }
    }
}