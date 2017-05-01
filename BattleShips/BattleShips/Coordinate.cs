using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    public class Coordinate
    {
        int x = 0;
        int y = 0;
        private bool shotAt;
        private Ship ship; // Just here so we can tell the ship to rebuild it it's sunk when shot at. More efficent than telling every ship to rebuild every input. Not null if no ship is assigned.

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void AssignShip(Ship ship)
        {
            this.ship = ship;
        }

        public bool ShootAt()
        {
            if (shotAt != true)
            {
                shotAt = true;
                if (ship != null) { ship.calcIsSunk(); }
            }
            return ship != null;
        }

        public bool ShotAt()
        {
            return shotAt;
        }

        public String Render()
        {
            if (shotAt && ship != null)
            {
                return "x";
            }
            else if (shotAt)
            {
                return "0";
            }
            else
            {
                return "~";
            }
        }
    }
}
