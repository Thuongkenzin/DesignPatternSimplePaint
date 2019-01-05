using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
     class Line : Shape
    {
        public Line(int x1, int y1, int x2,int y2)
        {
            this.info = new ShapeInfo(x1, y1, x2, y2);
        }
        public Line(Point start,Point end)
        {
            this.info = new ShapeInfo(start, end);
        }
        public override void draw(CommonGraphics g)
        {
            g.DrawLine(info.start.X, info.start.Y, info.end.X, info.end.Y);
        }
    }
}
