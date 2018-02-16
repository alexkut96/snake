using System;
using System.Collections.Generic;
namespace snake
{
    public class VerticalLine
    {
        List<Point> vList;
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            vList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                vList.Add(p);
            }
        }

        public void DrawY()
        {
            foreach (Point y in vList)
            {
                y.Draw();
            }
        }
    }
}
