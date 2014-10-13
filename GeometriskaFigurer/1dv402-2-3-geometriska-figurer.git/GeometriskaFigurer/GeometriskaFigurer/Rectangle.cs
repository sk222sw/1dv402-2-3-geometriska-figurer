using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Rectangle : Shape
    {
        public override double Area { get { return Area; } }

        public override double Perimeter { get { return Perimeter; } }

        public Rectangle(double length, double width) //Kallar på basklassens konstruktor
            :base (length, width){}
    }
}
