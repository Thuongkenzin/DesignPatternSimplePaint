using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    public class ShapeInfo
    {

        public Point start;
        public Point end;

        public ShapeInfo(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
        public ShapeInfo(int x1, int y1, int x2, int y2)
        {
            start.X = x1;
            start.Y = y1;
            end.X = x2;
            end.Y = y2;
        }
    }
}
