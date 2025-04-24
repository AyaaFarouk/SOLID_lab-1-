using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab1.Task2;

namespace Lab1
{
    internal class Task3
    {
        public interface IHeight
        {
            double Height { get; set; }
            //double SetHeight(double x);
        }
        public class Rectangle : IHeight
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public Rectangle(double width, double height)
            {
                this.Width = width;
                this.Height = height;
            }
        }

        public class Square : IHeight
        {
            public double Height { get; set; }

            public Square(double height)
            {
                this.Height = height;
            }
        }

    }

}
