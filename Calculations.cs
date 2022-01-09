using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Calculations
    {
        //public double Side { get; set; }
        //public double Height { get; set; }
        //public Calculations(double side, double height)
        //{
        //    Side = side;
        //    Height = height;
        //}
        public double SquareCircuit(double sideA)
        {
            double result;
            result = sideA * 4;
            return result;
        }
        public double SquareArea(double sideA, double result)
        {
            result = sideA * sideA;
            return result;
        }
        /*public double TriangleCircuit(double sideA, double sideB, double sideC )
        {
            double result;
            if (sideA != sideB && sideA != sideC && sideB != sideC)
            {
                result = sideA + sideB + sideC;
                return result;
            }
            else if(sideA == sideB && sideA != sideC && sideB != sideC)
            {
                result = (2 * sideA) + sideC;
                return result;
            }
            else if(sideA == sideB && sideA == sideC && sideB == sideC)
            {
                result = sideA * 3;
                return result;
            }
            
        }*/
        public double TriangleArea(double side, double height, double result)
        {
            result = (side * height) / 2;
            return result;
        }
        public double RectangleCircuit(double sideA, double sideB, double result)
        {
            result = (2 * sideA) + (2 * sideB);
            return result;
        }
        public double RectangleArea(double sideA, double sideB, double result)
        {
            result = sideA * sideB;
            return result;
        }
        public double CircleCircuit(double r, double result)
        {
            result = 2 * Math.PI * r;
            return result;
        }
        public double CircleArea(double r, double result)
        {
            result = Math.PI * Math.Pow(r, 2);
            return result;
        }
        public double CylinderMass(double r, double height, double result)
        {
            result = Math.PI * Math.Pow(r, 2) * height;
            return result;
        }
        public double CylinderAreaOfTheBase(double r, double result)
        {
            result = Math.PI * Math.Pow(r, 2);
            return result;
        }
        public double CylinderAreaofTheSurroundingSurface(double r, double result)
        {
            result = result = 2 * Math.PI * r;
            return result;
        }
        public double CylinderSurface(double r, double height, double result)
        {
            result = 2 * Math.PI * r * (r + height);
            return result;
        }
        public double CubeMass(double side, double result)
        {
            result = Math.Pow(side, 3);
            return result;
        }
    }
}
