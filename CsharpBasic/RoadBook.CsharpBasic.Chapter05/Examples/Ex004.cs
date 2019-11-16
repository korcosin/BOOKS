using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    class Ex004
    {
        public void Run()
        {
            Bread custard_cream_bread = new Bread();
            custard_cream_bread.Shape = "별모양";
            custard_cream_bread.Source = "슈크림";
            Console.WriteLine("{0} {1}빵", custard_cream_bread.Shape, custard_cream_bread.Source);

            Bread pizza_bread = new Bread();
            pizza_bread.Shape = "네모난";
            pizza_bread.Source = "피자";
            Console.WriteLine("{0} {1}빵", pizza_bread.Shape, pizza_bread.Source);
        }
    }
    
    class Bread
    {
        public string Shape { get; set; }
        public string Source { get; set; }
    }

}