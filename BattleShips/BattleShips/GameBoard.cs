using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class GameBoard
    {

        public const int boardSize = 20;
        private Coordinate[,] board = new Coordinate[boardSize, boardSize];
        private List<Ship> ships = new List<Ship>();
        const int numberOfShips = 4;

        public GameBoard()
        {
            ResetBoard();
            GenerateShips();
        }

        public void ResetBoard()
        {
            // reset board
            for (int x = 0; x < board.GetLength(0); x += 1)
            {
                for (int y = 0; y < board.GetLength(1); y += 1)
                {
                    board[x, y] = new Coordinate(x, y);
                }
            }

            //clear out and regenerate ships
            ships.Clear();

        }

        public void RenderBoard()
        {
            for (int x = 0; x < board.GetLength(0); x += 1)
            {
                for (int y = 0; y < board.GetLength(1); y += 1)
                {
                    Console.Write(board[x, y].Render() + " ");
                }
                Console.WriteLine("");
            }


        }

        public bool ShootAt(int x, int y)
        {
            return board[x, y].ShootAt();
        }

        public void GenerateShips()
        {
            /*
            for (int x = 0; x < numberOfShips; x++)
            {

            }
            */
            GenerateStaticShips();

        }

        public void GenerateStaticShips()
        {
            // Generates a some static ships, just something to test with.
            // Probably a bad idea for the coordinates to know of the ship and the ship to know of the coordinates but it's more efficent so meh..?

            List<Coordinate> Cs = new List<Coordinate>();

            Cs.Add(board[0, 1]);
            Cs.Add(board[0, 2]);
            Cs.Add(board[0, 3]);

            Ship ship = new Ship(Cs);
            ships.Add(ship);

            foreach (Coordinate c in Cs)
            {
                c.AssignShip(ship);
            }
        }
    }
}