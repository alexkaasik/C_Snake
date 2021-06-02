 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Veri : Figure
    {
        public Veri(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Point p in pList)
            {
                p.Draw();
            }

            //base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
