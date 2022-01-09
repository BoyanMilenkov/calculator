using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Triangle
    {
        public double SideA { get; set; }
        /*public double SideB { get; set; }
        public double SideC { get; set; }*/
        public double Height { get; set; }
        //public double result = 0;
        //public string Operation { get; set; }
        public Triangle(double sideA, double height /*, string operation*/)
        {
            this.SideA = sideA;
            this.Height = height;
            //this.Operation = operation;

            //switch (this.Operation)
            //{
            //    case "TriangleArea":
            //        result = (this.SideA * this.Height) / 2;
            //        break;
            //}
        }
        public double TriangleArea(double sideA, double height)
        {
            double result;
            result = (this.SideA * this.Height) / 2;
            return result;
        }

    }
}
