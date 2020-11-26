namespace RPNCalculatorLib
{
    [MathOperator("-")]
    public class Subtraction : IMathOperator
    {
        public double compute(double firstInput, double secondInput)
        {
            return firstInput - secondInput;
        }
    }
}
