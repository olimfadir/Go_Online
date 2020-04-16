using System;

namespace Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Player();
            var p2 = new Player();

            var board = new GameBoard();
            board.GetCurrentState();
            Console.WriteLine($"Hello World! {p1.ReturnMessage()}");
        }
    }
}
