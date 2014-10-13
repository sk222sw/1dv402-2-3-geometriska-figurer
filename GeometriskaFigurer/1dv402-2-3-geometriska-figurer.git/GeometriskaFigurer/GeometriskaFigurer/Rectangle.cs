using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Rectangle : Shape
    {
        public double Area { get; }

        public double Perimeter { get; }

        public Rectangle(double length, double width) //Kallar på basklassens konstruktor
            :base (length, width){}
    }
}
