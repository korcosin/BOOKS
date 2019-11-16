using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Works
{
    public class Exam001
    {
        public void Run()
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\dev\csharp\books\CsharpBasic\RoadBook.CsharpBasic.Chapter08\Examples");

            FileInfo[] files = directory.GetFiles();

            for (int idx = 0; idx < files.Length; idx++)
            {
                FileInfo file = files[idx];
                Console.WriteLine(file.Name);
            }
        }
    }
}