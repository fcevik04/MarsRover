using MarsRover;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{

    public class Rover
    {
        public Plateau Plateau { get; set; }
        public Coordinate Coordinate { get; set; }
        public Direction Direction { get; set; }

        public Rover(Plateau plateau, Coordinate coordinate, Direction direction)
        {
            this.Coordinate = coordinate;
            this.Plateau = plateau;
            this.Direction = direction;
        }
        private void Rotate(string direction)
        {
            if (direction == "L")
            {
                switch (this.Direction)
                {
                    case Direction.N:
                        this.Direction = Direction.W;
                        break;
                    case Direction.S:
                        this.Direction = Direction.E;
                        break;
                    case Direction.E:
                        this.Direction = Direction.N;
                        break;
                    case Direction.W:
                        this.Direction = Direction.S;
                        break;
                    default:
                        break;
                }
            }
            else if (direction == "R")
            {
                switch (this.Direction)
                {
                    case Direction.N:
                        this.Direction = Direction.E;
                        break;
                    case Direction.S:
                        this.Direction = Direction.W;
                        break;
                    case Direction.E:
                        this.Direction = Direction.S;
                        break;
                    case Direction.W:
                        this.Direction = Direction.N;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Move()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    this.Coordinate.Y += 1;
                    break;
                case Direction.S:
                    this.Coordinate.Y -= 1;
                    break;
                case Direction.E:
                    this.Coordinate.X += 1;
                    break;
                case Direction.W:
                    this.Coordinate.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void Start(string letters)
        {
            foreach (var letter in letters)
            {
                switch (letter)
                {
                    case 'M':
                        Move();
                        break;
                    case 'L':
                        Rotate("L");
                        break;
                    case 'R':
                        Rotate("R");
                        break;
                }
            }
        }
    }
}
