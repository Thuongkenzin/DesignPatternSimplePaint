using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class Eclip : Shape
    {
        int width, height;
        public Eclip(Point start, Point end)
        {
            this.info = new ShapeInfo(start, end);
            width = end.X;
            height = end.Y;

        }
        public Eclip(int x, int y, int width, int height)
        {
            this.info = new ShapeInfo(x, y, width, height);
            this.width = width;
            this.height = height;
        }
        public override void draw(CommonGraphics g)
        {
            g.DrawEclipse(info.start.X, info.start.Y, width, height);
        }
    }
}
