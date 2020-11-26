namespace RPNCalculatorLib
{
    [MathOperatorAttribute("+")]
    public class Addition : IMathOperator
    {
        public double compute(double firstInput, double secondInput)
        {
            return firstInput + secondInput;
        }
    }
}
