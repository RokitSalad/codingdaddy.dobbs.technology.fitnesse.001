using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitSharpTest
{
    public class Division
    {
        public double Numerator { get; set; }
        public double Denominator { get; set; }

        public double Quotient()
        {
            return Numerator/Denominator;
        }
    }
}
