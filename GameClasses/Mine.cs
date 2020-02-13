using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClasses
{
    public class Mine
    {
        public Mine(int x, int y)
        {
            this.PositionX = x;
            this.PositionY = y;
        }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string GetCoordinates()
        {
            return $"{this.PositionX} {this.PositionY}";
        }
    }
}
