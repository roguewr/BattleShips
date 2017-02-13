using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleShips
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            GameBoard GameBoard = new GameBoard();
=======
            GameBoard gb = new GameBoard();
            gb.Render();
            Console.ReadLine();
>>>>>>> origin/master

            GameBoard.RenderBoard();
            Console.ReadKey();

        }
    }
}
