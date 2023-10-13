using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class InvalidTriangle : Exception
    {
        private string error_message;

        public InvalidTriangle(String msg)
        {
            this.error_message = msg;
        }

        public override string ToString()
        {
            return error_message;
        }
    }
}
