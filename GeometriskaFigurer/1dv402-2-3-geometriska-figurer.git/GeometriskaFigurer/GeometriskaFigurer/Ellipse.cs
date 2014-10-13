using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Ellipse : Shape
    {
        public double Area { get; }     //Ska ange ellipsens area

        public double Perimeter { get; }    //ska ange ellipsens omkrets

        public Ellipse(double length, double width      //kallar på konstruktorn från basklassen Shape
            : base(length, width)
        {

        }
    }
}
