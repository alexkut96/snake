using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace snake
{
    class Snake
    {
        static void Main(string[] args)
        {
            
            Console.SetWindowSize(80, 28);
        
            // Отрисовка линий
            HorizontalLine upLine = new HorizontalLine(0,Console.BufferWidth - 1,0,'+');
            HorizontalLine downLine = new HorizontalLine(0, Console.BufferWidth - 1, Console.BufferHeight- 1, '+');
            VerticalLine leftLine = new VerticalLine(0, Console.BufferHeight-1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, Console.BufferHeight - 1 , Console.BufferWidth - 1, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрисовка Точек
            Point p1 = new Point(5, 6, '*');
            p1.Draw();


        }
    }
}
