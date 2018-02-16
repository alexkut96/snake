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
            List<Point> pList = new List<Point>();

            pList.Add(new Point(1, 3, '#'));
            pList.Add(new Point(3, 5, '$'));
            pList.Add(new Point(4, 4, '@'));
            pList.Add(new Point(8, 2, '^'));

            foreach(Point i in pList)
            {
                i.Draw();
            }
            Console.ReadKey();
        }
    }
}
