using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculatorLib
{
    public class Addition : IMathOperator
    {
        public double compute(double firstInput, double secondInput)
        {
            return firstInput + secondInput;
        }
    }
}
