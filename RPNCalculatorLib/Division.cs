namespace RPNCalculatorLib
{
    [MathOperator("/")]
    public class Division : IMathOperator
    {
        public double compute(double firstInput, double secondInput)
        {
            return firstInput / secondInput;
        }
    }
}
