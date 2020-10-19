using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Plateau
    {
        public string Name { get; set; }
        public Coordinate Coordinate { get; set; }

        public Plateau(string name, Coordinate coordinate)
        {
            this.Name = name;
            this.Coordinate = coordinate;
        }
    }
}
