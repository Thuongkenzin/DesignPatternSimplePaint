using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Block;
using FigureDraw.Block.FlowChartBlock;

namespace FigureDraw.Diagram
{
    class FCFactory : DiagramFactory
    {
        public override ArrowBlock createArrowBlock(ShapeInfo info)
        {
            throw new NotImplementedException();
        }

        public override DesicionBlock createDesicionBlock(ShapeInfo info)
        {
            throw new NotImplementedException();
        }

        public override EndBlock createEndBlock(ShapeInfo info)
        {
            throw new NotImplementedException();
        }

        public override InputBlock createInputBlock(ShapeInfo info)
        {
            return new FCInputBlock(info);
        }

        public override OutputBlock createOutputBlock(ShapeInfo info)
        {
            throw new NotImplementedException();
        }

        public override ProcessBlock createProcessBlock(ShapeInfo info)
        {
            throw new NotImplementedException();
        }

        public override StartBlock createStartBlock(ShapeInfo info)
        {
            return new FCStartBlock(info);
        }
    }
}
