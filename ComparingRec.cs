using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace calculator
{
    public class Icomp : IComparable<Icomp>
    {
        
        public double SideA { get; set; }
        public double SideB { get; set; }
        public Icomp(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }
        public int CompareTo([AllowNull] Icomp other)
        {
            int result = this.SideA.CompareTo(other.SideA); this.SideB.CompareTo(other.SideB);
            
            return result;
        }
    }
    public class RectComparer : IComparer<Icomp>
    {
        public int Compare([AllowNull] Icomp x, [AllowNull] Icomp y)
        {
            int result = x.SideA.CompareTo(y.SideA); y.SideB.CompareTo(x.SideB);

            return result;
        }
    }
}
