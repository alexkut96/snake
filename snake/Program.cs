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
            Point p1 = new Point(2, 3, '#');
            p1.Draw();

            Point p2 = new Point(3, 5, '@');
            p2.Draw();

            HorizontalLine h1 = new HorizontalLine(2, 40, 0, '_');
            h1.DrawH();
            HorizontalLine h2 = new HorizontalLine(2, 40, 10, '_');
            h2.DrawH();


            VerticalLine v1 = new VerticalLine(1, 10, 1, '|');
            v1.DrawY();
            VerticalLine v2 = new VerticalLine(1, 10, 40, '|');
            v2.DrawY();
        }
    }
}
