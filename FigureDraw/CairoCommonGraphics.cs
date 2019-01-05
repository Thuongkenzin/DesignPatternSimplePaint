using Cairo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class CairoCommonGraphics : CommonGraphics
    {
        Context lib;
        public CairoCommonGraphics(Context lib)
        {
            this.lib = lib;
        }
        public void DrawEclipse(int cx, int cy, int hradius, int vradius)
        {
            lib.Scale(hradius, vradius);
            lib.Arc(cx, cy, 40, 30, 30);
            lib.Stroke();
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            lib.MoveTo(x1, y1);
            lib.LineTo(x2, y2);
            lib.Stroke();
        }

       
        public void DrawPolygon(System.Drawing.Point[] points)
        {
            throw new NotImplementedException();
        }

        public void DrawRectangle(int x, int y, int width, int height)
        {
            lib.Rectangle(x, y, width, height);
            lib.Stroke();
        }
    }
}
