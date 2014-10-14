using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Rectangle : Shape
    {
        public override double Area { get { return Length * Width; } }      //Räknar ut rektangelns area

        public override double Perimeter { get { return (Length * 2) + (Width * 2); } }     //räknar ut rektangelns omkrets

        public Rectangle(double length, double width) //Kallar på basklassens konstruktor
            :base (length, width){}
    }
}
