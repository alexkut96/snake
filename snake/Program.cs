using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace snake
{
    class Snake
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '#');
            p1.Draw();

            Point p2 = new Point(3, 5, '@');
            p2.Draw();

            HorizontalLine p = new HorizontalLine(1, 6, 10, '+');
            p.Drow();


        }
    }
}
