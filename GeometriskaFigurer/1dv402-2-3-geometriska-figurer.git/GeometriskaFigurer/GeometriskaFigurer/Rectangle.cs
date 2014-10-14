using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Rectangle : Shape
    {
        public override double Area { get { return Length * Width; } }

        public override double Perimeter { get { return (Length * 2) + (Width * 2); } }

        public Rectangle(double length, double width) //Kallar på basklassens konstruktor
            :base (length, width){}
    }
}
