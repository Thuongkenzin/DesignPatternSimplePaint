using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public class GdiPlusCommonGraphics : CommonGraphics
    {
        protected Graphics lib;
        protected Control control;

        public GdiPlusCommonGraphics(Graphics lib,Control control)
        {
            this.lib = lib;
            this.control = control;
        }

        public void DrawEclipse(int cx, int cy, int hradius, int vradius)
        {
            lib.DrawEllipse(Pens.Black, cx, cy, hradius, vradius);
            //lib.DrawEllipse(new Pen(Color.Black), new Rectangle(cx, cy, hradius, vradius));
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            lib.DrawLine(Pens.Black, x1, y1, x2, y2);
            
        }

        public void DrawPolygon(Point[] points)
        {
            lib.DrawPolygon(Pens.Black, points);
        }

        public void DrawRectangle(int x, int y, int width, int height)
        {
            lib.DrawRectangle(new Pen(Color.Black), x, y, width, height);
        }
    }
}
