using System;

namespace RoadBook.CsharpBasic.Chapter07.Examples.UserException
{
    class MyStyleException : Exception
    {
        public MyStyleException(){ }

        public MyStyleException(string message) : base(message) { }
    }
}