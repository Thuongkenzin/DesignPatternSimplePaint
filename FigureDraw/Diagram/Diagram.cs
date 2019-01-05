using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    class Diagram: Shape
    {
        List<ABlock> blocks;
        DiagramFactory factory;

        public Diagram(List<ABlock> blocks, DiagramFactory factory)
        {
            this.blocks = blocks;
            this.factory = factory;
        }
        public Diagram(DiagramFactory f)
        {
            this.factory = f;
        }
        public override void draw(CommonGraphics g)
        {
            foreach(ABlock block in blocks)
            {
                block.draw(g);
            }
        }
        public void addBlock(ABlock block)
        {
            blocks.Add(block);
        }
    }
}
