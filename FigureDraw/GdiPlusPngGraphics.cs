using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    class GdiPlusPngGraphics : GdiPlusCommonGraphics
    {
        public GdiPlusPngGraphics(Graphics lib, Control control) : base(lib, control)
        {
        }
        public void saveImage()
        {
            Bitmap bitmap = new Bitmap(control.Size.Width, control.Size.Height);
            Graphics graphic = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphic.CopyFromScreen(rect.Location, Point.Empty, control.Size);

            string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string filePath = "d:\\" + filename + ".Png";
            bitmap.Save(filePath, ImageFormat.Png);
        }
    }
}
