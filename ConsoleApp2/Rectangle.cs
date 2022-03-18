using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle:Shape
    {
        private double width, length;

        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }

        public Rectangle(double w,double len)
        {
            this.width = w;
            this.Length = len;
        }

        public double getArea() //求面积
        {
            return width * length;
        }

        public double getPerimeter() //求周长
        {
            return 2 * (width + length);
        }


    }
}
