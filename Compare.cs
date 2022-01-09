using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace calculator
{
    public class Compare : IComparable<Cylinder>
    {
        public int CompareTo([AllowNull] Cylinder other)
        {
            throw new NotImplementedException();
        }
    }
}
