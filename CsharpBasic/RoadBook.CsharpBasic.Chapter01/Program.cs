namespace RoadBook.CsharpBasic.Chapter01
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.Hello hello = new Examples.Hello();
            hello.Run();

            System.Console.WriteLine("계속 하시려면 아무 키나 누르세요.");
            System.Console.ReadKey();
        }
    }
}