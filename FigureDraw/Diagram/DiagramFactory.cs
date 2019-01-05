using FigureDraw.Block;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
     abstract class DiagramFactory
    {
        public abstract StartBlock createStartBlock(ShapeInfo info);
        public abstract InputBlock createInputBlock(ShapeInfo info);
        public abstract ArrowBlock createArrowBlock(ShapeInfo info);
        public abstract EndBlock createEndBlock(ShapeInfo info);
        public abstract OutputBlock createOutputBlock(ShapeInfo info);
        public abstract ProcessBlock createProcessBlock(ShapeInfo info);
        public abstract DesicionBlock createDesicionBlock(ShapeInfo info);

    }
}
