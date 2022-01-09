using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace calculator
{
    public class Cylinder 
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        //public double result = 0;
        //public string Operation { get; set; }
        public Cylinder(double radius, double height /*string operation*/)
        {
            this.Radius = radius;
            this.Height = height;
            //this.Operation = operation;
            //switch (this.Operation)
            //{
            //    case "CylinderMass":
            //        result = Math.PI * Math.Pow(this.Radius, 2) * this.Height; 
            //        break;
            //    case "CylinderAreaOfTheBase":
            //        result = Math.PI * Math.Pow(this.Radius, 2);
            //        break;
            //    case "CylinderAreaofTheSurroundingSurface":
            //        result = 2 * Math.PI * this.Radius;
            //        break;
            //    case "CylinderSurface":
            //        result = 2 * Math.PI * this.Radius * (this.Radius + this.Height);
            //        break;
            //}
        }
        public double CylinderMass(double radius, double height)
        {
            double result;
            result = Math.PI * Math.Pow(this.Radius, 2) * this.Height;
            return result;
        }
        public double CylinderAreaOfTheBase(double radius)
        {
            double result;
            result = Math.PI * Math.Pow(this.Radius, 2);
            return result;
        }
        public double CylinderAreaofTheSurroundingSurface(double radius)
        {
            double result;
            result = 2 * Math.PI * this.Radius;
            return result;
        }
        public double CylinderSurface(double radius, double height)
        {
            double result;
            result = 2 * Math.PI * this.Radius * (this.Radius + this.Height);
            return result;
        }
        
    }
}
