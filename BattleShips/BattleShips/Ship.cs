using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    public class Ship
    {
        int length;
        List<Coordinate> coordinates;
        private bool sunk;

        public Ship(List<Coordinate> coordinates)
        {
            this.coordinates = coordinates;
            length = coordinates.Count;
        }

        public bool IsSunk()
        {
            return sunk;
        }

        public void calcIsSunk()
        {
            sunk = true;
            foreach (Coordinate c in coordinates)
            {
                if(c.ShotAt()) {
                    sunk = false;
                    break;
                }
            }
        } 
    }
}
