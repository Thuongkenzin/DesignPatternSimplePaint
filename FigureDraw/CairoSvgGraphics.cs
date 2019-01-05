using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cairo;

namespace FigureDraw
{
    class CairoSvgGraphics : CairoCommonGraphics
    {
        public CairoSvgGraphics(Context lib) : base(lib)
        {
        }
    }
}
