using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Square
    {
        public double SideA { get; set; }
        
        //public double result = 0;
        //public string Operation { get; set; }
        public Square(double sideA /*, string operation*/)
        {
            this.SideA = sideA;
            //this.Operation = operation;

            //switch (this.Operation)
            //{
            //    case "SquareCircuit":
            //        result = this.SideA * 4;
            //        break;
            //    case "SquareArea":
            //        result = this.SideA * this.SideA;
            //        break;
            //}
        }
        public double SquareCircuit(double result)
        {
            result = this.SideA * 4;
            return result;
        }
        public double SquareArea(double result)
        {
            result = this.SideA * this.SideA;
            return result;
        }
    }
}
