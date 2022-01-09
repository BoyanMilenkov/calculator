using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Generic<T>
    {
        public T SideA { get; set; }
        public T SideB { get; set; }

        public Generic(T sideA, T sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }
        public bool Equal()
        {
            if (SideA.Equals(SideB))
            {
                return true;
            }
            return false;
        }
    }
}
