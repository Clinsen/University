using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class Complex : RealNum
    {
        private double imaginary;

        public Complex(double real, double ival)
        {
            this.real = real;
            this.imaginary = ival;
        }
        public Complex()
        {
            this.real = 0.0;
            this.imaginary = 0.0;
        }

        public double Get_Set_Ival
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public double Get_Complex()
        {
            return imaginary + real;
        }

        public override double Calculate_norm()
        {
            return Math.Abs(Get_Complex());
        }
    }
}
