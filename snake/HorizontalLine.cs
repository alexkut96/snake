using System;
using System.Collections.Generic;
namespace snake
{
    public class HorizontalLine
    {
        List<Point> hList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            hList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,sym);
                hList.Add(p);
            }
        }

        public void DrawH()
        {
            foreach (Point h in hList)
            {
                h.Draw();
            }    
        }
    }
}
           
