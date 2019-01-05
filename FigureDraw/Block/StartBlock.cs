using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Block
{
    abstract class StartBlock:ABlock
    {
        public StartBlock(Point x, Point y)
        {
            this.info = new ShapeInfo(x, y);
        }
        public StartBlock(ShapeInfo info)
        {
            this.info = info;
        }
    }
}
