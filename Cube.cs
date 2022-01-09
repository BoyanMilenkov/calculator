using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Cube
    {
        public double Side { get; set; }
        //public double result = 0;
        //public string Operation { get; set; }
        public Cube(double side /*string operation*/)
        {
            this.Side = side;
            //this.Operation = operation;
            //switch (this.Operation)
            //{
            //    case "CubeMass":
            //        result = Math.Pow(this.Side, 3);
            //        break;
            //}
        }
        public double CubeMass(double result)
        {
            result = Math.Pow(this.Side, 3);
            return result;
        }
    }
}
