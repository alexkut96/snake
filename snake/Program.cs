using System;

namespace snake
{
    class Snake
    {
        public static void Main(string[] args)
        {
            List<Point> pList = new List<Point>();

            pList.add(Point(1, 3, '#'));
            pList.add(Point(3, 5, '$'));
            pList.add(Point(4, 4, '@'));
            pList.add(Point(8, 2, '^'));

            foreach(Point i in pList)
            {
                i.Draw();
            }
            Console.ReadLine();
        }
    }
}
