using System;
using System.Collections.Generic;
using System.Text;

namespace MySnake
{
    class VerticalLine
    {
        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {

                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }

        List<Point> pList;
    }
}
   
 