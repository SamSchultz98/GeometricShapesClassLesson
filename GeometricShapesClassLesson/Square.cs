using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesClassLesson
{
    internal class Square : Rect
    {
       

        public Square(int side): base(side,side)      
        {
            Side1 = side;
        }
        public override string Print()
        {
            return $"All Sides [{Side1}]";
        }


    }
}
