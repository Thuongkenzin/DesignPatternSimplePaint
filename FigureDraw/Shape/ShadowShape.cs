using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class ShadowShape : EffectedShape
    {
        public override void draw(CommonGraphics g)
        {
            throw new NotImplementedException();
        }

        protected override void format(CommonGraphics g, Shape shape)
        {
            shape.draw(g);
        }
    }
}
