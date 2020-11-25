namespace RPNCalculatorLib
{
    public class Multiplication : IMathOperator
    {
        public double compute(double firstInput, double secondInput)
        {
            return firstInput * secondInput;
        }
    }
}
