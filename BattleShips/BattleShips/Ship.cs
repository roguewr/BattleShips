using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Ship
    {
        int length;
        List<Coordinate> coordinates;

        public Ship(List<Coordinate> coordinates)
        {
            this.coordinates = coordinates;
            length = coordinates.Count;
        }

    }

    public class Coordinate
    {
        int x = 0;
        int y = 0;
        public bool shotAt = false;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        void ShootAt()
        {
            shotAt = true;
        }

        string getSymbol()
        {
            if (shotAt)
            {
                return "0";
            } else
            {
                return "~";
            }


        }


    }
}
