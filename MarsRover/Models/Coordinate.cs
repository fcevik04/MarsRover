using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
