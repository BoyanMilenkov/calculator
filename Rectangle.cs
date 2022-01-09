using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Rectangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        //public double result = 0;
        //public string Operation { get; set; }
        public Rectangle(double sideA, double sideB /*, string operation*/)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            //this.Operation = operation;
            //switch (this.Operation)
            //{
            //    case "RectangleCircuit":
            //        result = (2 * this.SideA) + (2 * this.SideB);
            //        break;
            //    case "RectangleArea":
            //        result = (this.SideA) * (this.SideB);
            //        break;
            //}
        }
        public double RectangleCircuit(double sideA, double sideB)
        {
            double result;
            result = (2 * this.SideA) + (2 * this.SideB);
            return result;
        }
        public double RectangleArea(double sideA, double sideB)
        {
            double result;
            result = (this.SideA) * (this.SideB);
            return result;
        }
        
    }
}
