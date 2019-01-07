using Cairo;
using FigureDraw.Block.FlowChartBlock;
using FigureDraw.Diagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public partial class Form1 : Form
    {
        private int ShapeType = 0;
        int GraphicType = 0;
        System.Drawing.Point Start;
        System.Drawing.Point End;
        System.Drawing.Graphics g;
        CommonGraphics gdi;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Paint += new System.Windows.Forms.PaintEventHandler(Form1_Paint);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g;
            //g = panelcontrol.CreateGraphics();

            //CommonGraphics a = new GdiPlusCommonGraphics(g, panelcontrol);
            //Shape rect = new Rect(0, 0, 150, 250);
            //rect.draw(a);
            //Shape eclip = new Eclip(0, 0, 150, 250);
            //eclip.draw(a);
            //Shape line = new Line(0, 0, 150, 250);
            //line.draw(a);
            
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = 0;
        }

        private void panelcontrol_MouseDown(object sender, MouseEventArgs e)
        {
            Start.X = e.X;
            Start.Y = e.Y;
        }

        private void panelcontrol_MouseUp(object sender, MouseEventArgs e)
        {
            End.X = e.X;
            End.Y = e.Y;
            g = panelcontrol.CreateGraphics();
            DiagramFactory fac = new DfdFactory();
            ShapeInfo temp = new ShapeInfo(Start, End);
            DiagramFactory fac2 = new FCFactory();
            CommonGraphics gdi1 = new GdiPlusCommonGraphics(g, panelcontrol);
            //chon graphic
            if(GraphicType == 0)
            {
                gdi = gdi1;
            }
            else
            {
                try
                {
                    Surface s = new Win32Surface(g.GetHdc());
                    Context c = new Context(s);
                    gdi = new CairoCommonGraphics(c);
                }catch(System.DllNotFoundException)
                {
                    GraphicType = 0;
                    MessageBox.Show("DllNotFoundException", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            //chon hinh ve
            switch (ShapeType)
            {
                case 0:
                    Shape line = new Line(Start, End);
                    line.draw(gdi);
                    
                    break;
                case 1:
                    Shape rect = new Rect(Start, End);
                    rect.draw(gdi);
                    break;
                case 2:
                    Shape eclip = new Eclip(Start, End);
                    eclip.draw(gdi);
                    break;
                case 3:
                   
                    ABlock startblock = fac.createStartBlock(temp);
                    startblock.draw(gdi);
                    break;
                case 4:
                    ABlock input = fac.createInputBlock(temp);
                    input.draw(gdi);
                    break;
                case 5:
                    ABlock startbl = fac2.createStartBlock(temp);
                    startbl.draw(gdi);
                    break;
                case 6:
                    ABlock inputbl = fac2.createInputBlock(temp);
                    inputbl.draw(gdi);
                    break;
                case 7:
                    Shape star = new Star(Start, End);
                    star.draw(gdi);
                    break;
                default:
                    break;
            }
            
        }

        

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = 1;
        }

        private void eclipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = 2;
        }

        private void saveJpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GraphicType == 0)
            {
                GdiPlusJpegGraphics jpeg = new GdiPlusJpegGraphics(g, panelcontrol);
                jpeg.saveImage();
            }
            if(GraphicType == 1)
            {
                //luu bang cairo
            }
        }
        

        private void gdiPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicType = 0;
        }

        private void cairoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicType = 1;
        }

        private void savePngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GraphicType == 0)
            {
                GdiPlusPngGraphics png = new GdiPlusPngGraphics(g, panelcontrol);
                png.saveImage();
            }
            if (GraphicType == 1)
            {
                //luu bang cairo
            }
        }

        private void startBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = 3;
        }

        private void inputBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = 4;
        }

        private void startBlockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShapeType = 5;
        }

        private void inputBlockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShapeType = 6;
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = 7;
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelcontrol.Invalidate();
        }
    }
}
