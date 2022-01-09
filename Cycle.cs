using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Cycle
    {
        public double Radius { get; set; }
        //public double result = 0;
        //public string Operation { get; set; }
        public Cycle(double radius /*string operation*/)
        {
            this.Radius = radius;
            //this.Operation = operation;
            //switch (this.Operation)
            //{
            //    case "CircleCircuit":
            //        result = 2 * Math.PI * this.Radius;
            //        break;
            //    case "CircleArea":
            //        result = Math.PI * Math.Pow(this.Radius, 2);
            //        break;
            //}
        }
        public double CircleCircuit(double result)
        {
            result = 2 * Math.PI * this.Radius;
            return result;
        }
        public double CircleArea(double result)
        {
            result = Math.PI * Math.Pow(this.Radius, 2);
            return result;
        }

    }
}
