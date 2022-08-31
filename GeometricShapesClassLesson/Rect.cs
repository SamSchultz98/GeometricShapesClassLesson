using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesClassLesson
{
    internal class Rect : Quad
    {

        public int Area()
        {
            return Side1 * Side2;
        }

        public Rect(int Side1, int Side2) : base(Side1, Side2, Side1, Side2)
        {

        }

        public override string Print()
        {
            return $"Side1[{Side1}], Side2[{Side2}]";
        }



    }
}

        //public int Side1 { get; set; }
        //public int Side2 { get; set; }

        //public int Perimeter()
        //{
        //    return 2*(Side1 + Side2);
        //}

        //public int Area()
        //{
        //    return Side1 * Side2;
        //}

        //public Rect(int side1, int side2)
        //{
        //    Side1 = side1;
        //    Side2 = side2;

        //}