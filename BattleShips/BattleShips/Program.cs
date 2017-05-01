using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleShips
{
    class Program
    {
        static GameBoard GameBoard;

        static void Main(string[] args)
        {

            GameBoard = new GameBoard();
            String input;
            String output = "";

            GameBoard.RenderBoard();
            Console.WriteLine("Please end a new set of coordinate in the form 'x y' with a space inbetween. Other Commands: 'end', 'reset', 'show ships'");

            do {
                // Main Game Loop

                Console.Clear();
                GameBoard.RenderBoard();
                if (output != "") { Console.WriteLine(output); }
                Console.WriteLine("Please end a new set of coordinate in the form 'x y' with a space inbetween. Other Commands: 'end', 'reset', 'show ships'");

                input = Console.ReadLine().ToString().ToLower();
                output = "";

                switch(input)
                {
                    case "end":
                        // Do Nothing
                        break;
                    case "reset":
                        // Do Nothing (for now)
                        break;
                    case "show ships": case "showships":
                        // Do Nothing (for now)
                        break;
                    default:
                        // Coordinates
                        input = input.Trim();
                        if (!input.Contains(" "))
                        {
                            output = "Invalid Input";
                            continue;
                        }

                        string xstr = input.Split(Convert.ToChar(" "))[0];
                        string ystr = input.Split(Convert.ToChar(" "))[1];
                        int x;
                        int y;

                        if (!int.TryParse(xstr, out x))
                        {
                            output = "Invalid X coordinate";
                            continue;
                        }

                        if (!int.TryParse(ystr, out y))
                        {
                            output = "Invalid Y coordinate";
                            continue;
                        }
                        
                        if (x > GameBoard.boardSize || x < 0)
                        {
                            output = "X coordinate outside range of board";
                        }

                        if (y > GameBoard.boardSize || y < 0)
                        {
                            output = "Y coordinate outside range of board";
                        }

                        if (GameBoard.ShootAt(x, y))
                        {
                           output = "Hit!";
                            
                        }
                        else
                        {
                            output = "Miss.";

                        }
                        break;
                }

            } while (input != "end");


        }


        /* To Do List
         * =========================
         * 
         * Number of Ships Left
         * Number Of Shots
         * Number Of Misses vs Hits
         * Any other insulting facts? Duplicate Shots, invalid shots and commands?
         * 
         * 
         */


    }
}
