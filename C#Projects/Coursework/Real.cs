using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class RealNum
    {
        protected double real;

        public RealNum()
        {
        }

        public RealNum(double real)
        {
            this.real = real;
        }

        public double Get_Set_Real
        {
            get { return real; }
            set { real = value; } 
        }

        public virtual double Calculate_norm()
        {
            return Math.Abs(real);
        }
    }
}
