using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Ellipse : Shape
    {
        public override double Area { get { return Area; } }     //Ska ange ellipsens area

        public override double Perimeter { get { return Perimeter; } }    //ska ange ellipsens omkrets

        public Ellipse(double length, double width)      //kallar på konstruktorn från basklassen Shape
            : base(length, width)
        {

        }
    }
}
