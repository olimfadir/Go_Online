using System;

namespace Go
{
    public class GameBoard
    {
        private char[,] board;

        public GameBoard(){
            this.board = new char[18,18];
        }

        public void GetCurrentState()
        {
            for(int i=0; i<this.board.GetLength(0); i++){
                for(int j=0; j< this.board.GetLength(1); j++){
                    Console.Write("0,");
                }
                Console.WriteLine("");
            }
        }
    }
}