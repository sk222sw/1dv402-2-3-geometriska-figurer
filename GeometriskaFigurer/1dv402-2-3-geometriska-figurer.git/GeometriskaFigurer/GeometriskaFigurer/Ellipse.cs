using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Ellipse : Shape
    {
        public double Area { get { return (Math.PI * (Length / 2) * (Width / 2)); } }     //Ska ange ellipsens area       //Override?

        public double Perimeter { get { return Math.PI * Math.Sqrt((2 * Length * Length) + (2 * Width * Width)); } }    //ska ange ellipsens omkrets       //Override?

        public Ellipse(double length, double width)      //kallar på konstruktorn från basklassen Shape
            : base(length, width)
        {

        }
    }
}
