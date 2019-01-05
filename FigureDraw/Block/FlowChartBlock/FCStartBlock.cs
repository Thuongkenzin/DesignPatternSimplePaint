using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Block.FlowChartBlock
{
    class FCStartBlock : StartBlock
    {
        public FCStartBlock(ShapeInfo info) : base(info)
        {
        }

        public FCStartBlock(Point x, Point y) : base(x, y)
        {
        }

        public override void draw(CommonGraphics g)
        {
            int width = Math.Abs(info.end.X - info.start.X);
            int height = Math.Abs(info.end.Y - info.start.Y);
            int size = width > height ? height : width;
            g.DrawEclipse(info.start.X, info.start.Y, size, size);
        }
    }
}
