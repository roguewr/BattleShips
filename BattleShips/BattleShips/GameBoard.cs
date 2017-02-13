using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class GameBoard
    {
<<<<<<< HEAD
        private Coordinate[,] board = new Coordinate[20, 20];

        public GameBoard()
        {
            for (int x = 0; x < board.GetLength(0); x += 1)
            {
                for (int y = 0; y < board.GetLength(1); y += 1)
                {
                    board[x, y] = new Coordinate(x, y);
                }
            }
        }

        public void RenderBoard()
        {
            for (int x = 0; x < board.GetLength(0); x += 1)
            {
                for (int y = 0; y < board.GetLength(1); y += 1)
                {
                    Console.Write(getSpot(x,y) + " ");
                }
                Console.WriteLine("");
            }


        }

        public string getSpot(int x, int y)
        {
            if (board[x, y].shotAt)
            {
                return "X";
            } else
            {
                return "0";
            }


        }


    }
}
=======
        //bool [,] board = new bool[20,20];

        public GameBoard() { }

        
        //public void RenderBoard()
        //{
        //    for (int i=0; i<board.GetLength(0); i++)
        //    {
        //        for (int j=0; j<board.GetLength(1); j++)
        //        {
        //            Console.Write(board[i, j] + " ");
        //        }
        //        Console.Write("");
        //    }
        //}

        public void Render()
        {
            Console.WriteLine("helloworld2");
        }
    }
}


>>>>>>> origin/master
