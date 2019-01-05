using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class Rect : Shape
    {
        int width, height;
        public Rect(Point start, Point end)
        {
            this.info = new ShapeInfo(start, end);
            this.width = end.X;
            this.height = end.Y;
        }
        public Rect(int x1, int y1, int width, int height)
        {
            this.info = new ShapeInfo(x1,y1,width,height);
            this.width = width;
            this.height = height;
        }
        public override void draw(CommonGraphics g)
        {
            g.DrawRectangle(info.start.X, info.start.Y, width, height);
        }
    }
}
