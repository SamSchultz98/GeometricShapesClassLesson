using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesClassLesson
{
    internal class Square
    {
        public int Side1 { get; set; }

        public int Perimeter()
        {
            return Side1 * 4;
        }

        public int Area()
        {
            return Side1 * Side1;
        }

        public Square(int side)
        {
            Side1 = side;
        }



    }
}
