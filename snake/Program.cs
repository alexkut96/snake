using System;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1-st Point
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            // 2-nd Point
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

        }
    }
}
