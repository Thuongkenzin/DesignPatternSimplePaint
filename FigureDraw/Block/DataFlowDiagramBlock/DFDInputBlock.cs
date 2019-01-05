using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Block.DataFlowDiagramBlock
{
    class DFDInputBlock : InputBlock
    {
        public DFDInputBlock(ShapeInfo Info) : base(Info)
        {
        }

        public DFDInputBlock(Point x, Point y) : base(x, y)
        {
        }

        public override void draw(CommonGraphics g)
        {
            int scale = 8;
            Point min = new Point();
            min.X = info.start.X < info.end.X ? info.start.X : info.end.X;
            min.Y = info.start.Y < info.end.Y ? info.start.Y : info.end.Y;
            Point max = new Point();
            max.X = info.start.X > info.end.X ? info.start.X : info.end.X;
            max.Y = info.start.Y > info.end.Y ? info.start.Y : info.end.Y;

            int width = Math.Abs(info.end.X - info.start.X);
            int height = Math.Abs(info.end.Y - info.start.Y);
            g.DrawRectangle(min.X, min.Y, width, height);

            Point point1 = new Point();
            point1.X = min.X + width / scale;
            point1.Y = min.Y;

            Point point2 = new Point();
            point2.X = min.X + width / scale;
            point2.Y = max.Y;

            Point point3 = new Point();
            point3.X = max.X - width / scale;
            point3.Y = min.Y;

            Point point4 = new Point();
            point4.X = max.X - width / scale;
            point4.Y = max.Y;

            g.DrawLine(point1.X,point1.Y,point2.X,point2.Y);
            g.DrawLine(point3.X, point3.Y, point4.X, point4.Y);
        }
    }
}
