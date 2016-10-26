using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Point p1 = new Point(1, 3, '*');

            Point p2 = new Point(4, 5, '#');

            Point p3 = new Point(5, 6, '7');

            Point p4 = new Point(7, 8, '8');

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');

            line.Draw();

            Console.ReadLine();
        }

        
    }
}
