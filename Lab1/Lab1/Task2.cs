using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Task2
    {
        public interface ICalcArea
        {
            double CalcArea();
        }
        public interface ICalcVolume
        {
            double CalcVolume();
        }
//---------------------------------------------------
        public class Rectangle : ICalcArea
        {
            public double Height { get; set; }
            public double Wight { get; set; }

            public Rectangle(double Height, double Wight)
            {
                this.Height = Height;
                this.Wight = Wight;
            }

            public double CalcArea()
            {
                return Height * Wight ;
            }
        }
//---------------------------------------------------------
        public class Circle : ICalcArea
        {
            public double Radius { get; set; }

            public Circle(double Radius)
            {
                this.Radius = Radius;
            }
            public double CalcArea()
            {
               return Radius * Radius * Math.PI;
            }
        }
        //---------------------------------------------------------
        public class Square : ICalcArea
        {
            public double Length { get; set; }

            public Square(double Length)
            {
                this.Length = Length;
            }

            public double CalcArea()
            {
                return Length*Length;
            }
        }
        //-------------------------------------------------------
        public class Triangle : ICalcArea
        {
            public double Height { get; set; }
            public double BaseLength { get; set; }
            
            public Triangle(double BaseLength, double Height)
            {
                this.BaseLength = BaseLength;
                this.Height = Height;
            }

            public double CalcArea()
            {
                return 0.5*Height* BaseLength;
            }
        }
        //--------------------------------------------------------
        public class Cube : ICalcArea, ICalcVolume
        {
            public double Length { get; set; }

            public Cube(double Length)
            {
                this.Length = Length;
            }
            public double CalcArea()
            {
                return 6* Math.Pow(Length, 2);
            }

            public double CalcVolume()
            {
                return Math.Pow(Length, 3);
            }
        }
//----------------------------------------------------------------
        public class AreaCalculator
        {
            public double TotalArea(ICalcArea[] arrObjects)
            {
                double area = 0;

                foreach (var obj in arrObjects)
                {
                    area += obj.CalcArea();
                }
                return area;
            }
        }
        //-------------------------------------------------------------
        public class VolumeCalculator
        {
            public double TotalArea(ICalcVolume[] arrObjects)
            {
                double volume = 0;

                foreach (var obj in arrObjects)
                {
                    volume += obj.CalcVolume();
                }
                return volume;
            }
        }

    }
}
