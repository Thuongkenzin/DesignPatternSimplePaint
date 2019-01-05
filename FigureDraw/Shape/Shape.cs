using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
     abstract class Shape
    {

        protected ShapeInfo info;

        public abstract void draw(CommonGraphics g);
    }
}
