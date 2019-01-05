using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Block.FlowChartBlock
{
    class FCInputBlock : InputBlock
    {
        public FCInputBlock(ShapeInfo Info) : base(Info)
        {
        }

        public FCInputBlock(Point x, Point y) : base(x, y)
        {
        }

        public override void draw(CommonGraphics g)
        {
            int distance = 30;
            Point min = new Point();
            min.X = info.start.X < info.end.X ? info.start.X : info.end.X;
            min.Y = info.start.Y < info.end.Y ? info.start.Y : info.end.Y;
            Point max = new Point();
            max.X = info.start.X > info.end.X ? info.start.X : info.end.X;
            max.Y = info.start.Y > info.end.Y ? info.start.Y : info.end.Y;

            Point point1 = new Point();
            point1.X = min.X + distance;
            point1.Y = min.Y;

            Point point2 = new Point();
            point2.X = max.X;
            point2.Y = min.Y;

            Point point3 = new Point();
            point3.X = max.X - distance;
            point3.Y = max.Y;

            Point point4 = new Point();
            point4.X = min.X;
            point4.Y = max.Y;

            Point[] points = { point1, point2, point3, point4 };
            g.DrawPolygon(points);
        }
    }
}
