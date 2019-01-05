using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    interface CommonGraphics
    {
        void DrawLine(int x1, int y1, int x2, int y2);
        void DrawRectangle(int x, int y, int width, int height);
        void DrawEclipse(int cx, int cy, int hradius, int vradius);
        void DrawPolygon(Point[] points);
    }
}
