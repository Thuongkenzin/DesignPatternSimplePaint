using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Block
{
    abstract class InputBlock:ABlock
    {
        public InputBlock(Point x,Point y)
        {
            this.info = new ShapeInfo(x, y);
        }
        public InputBlock(ShapeInfo Info)
        {
            this.info = Info;
        }
    }
}
