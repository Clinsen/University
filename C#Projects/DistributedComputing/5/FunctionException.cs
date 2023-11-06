using System;

namespace FunctionCalculator
{
    class FunctionException : Exception
    {
        public FunctionException(string message) : base(message)
        {
        }
    }
}
