using System;

namespace Methods
{
    class Point
    {
        public int UpperX;
        public int UpperY;

        public Point(int lowerx, int lowery)
        {
            this.UpperX = lowerx;
            this.UpperY = lowery;
        }

        public void Move(int x, int y)
        {
            this.UpperX = x;
            this.UpperY = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            Move(newLocation.UpperX, newLocation.UpperY);

        }
    }
}