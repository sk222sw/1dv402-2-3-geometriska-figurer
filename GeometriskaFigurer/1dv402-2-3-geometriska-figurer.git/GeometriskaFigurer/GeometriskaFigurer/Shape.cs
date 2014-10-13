using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    public abstract class Shape
    {
        private double _length;     //representerar en figurs längd.
        private double _width;      //representerar en figurs bredd.

        public abstract double Area { get; } //representerar en figurs area

        public double Length        //kapslar in _length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;

            }    //set kastar undantag om värdet är mindre än 0.
        }

        public abstract double Perimeter { get; }    //representerar en figurs omkrets.

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }       //kapslar in _width

        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            //Metoden ska returnera en 
            //sträng representerande värdet av en instans. Strängen ska vara lite speciellt formaterad och på separata 
            //rader innehålla ledtext och värde för figurens läng, bredd, omkrets och area.
            string hej = "hej";
            return hej;
        }
   } 
}
