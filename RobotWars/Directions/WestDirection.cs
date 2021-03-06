﻿namespace RobotWars
{
    public class WestDirection : DirectionBase
    {
        protected internal override Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X - 1, coordinate.Y);
        }

        protected internal override DirectionBase RotateRight()
        {
            return new NorthDirection();
        }

        protected internal override DirectionBase RotateLeft()
        {
            return new SouthDirection();
        }

        public override string ToString()
        {
            return "W";
        }
    }
}