using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class Star : Shape
    {
        public Star(Point start, Point end)
        {
            this.info = new ShapeInfo(start, end);
        }
        public override void draw(CommonGraphics g)
        {
            PointF[] pts = StarPoints(5, new Rectangle(info.start.X, info.start.Y, info.end.X, info.end.Y));
            for (int i = 0; i < 4; i++)
            {
                g.DrawLine((int)pts[i].X, (int)pts[i].Y, (int)pts[i + 1].X, (int)pts[i + 1].Y);
            }
            g.DrawLine((int)pts[4].X, (int)pts[4].Y, (int)pts[0].X, (int)pts[0].Y);
        }
        private PointF[] StarPoints(int num_points, Rectangle bounds)
        {
            PointF[] pts = new PointF[num_points];

            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;

            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }
    }
}
