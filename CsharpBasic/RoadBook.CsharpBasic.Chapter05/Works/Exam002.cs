using System;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class Exam002
    {
        Examples.Service.BoardService _boardService;

        public void Run()
        {
            Examples.Model.Board board = new Examples.Model.Board();
            Console.Write("제목을 입력하세요: ");
            board.Title = Console.ReadLine();
            Console.Write("내용을 입력하세요: ");
            board.Contents = Console.ReadLine();
            Console.Write("작성자 이름을 입력하세요: ");
            board.Writer = Console.ReadLine();

            _boardService = new Examples.Service.BoardService(board);

            _boardService.Read();
        }
    }
}