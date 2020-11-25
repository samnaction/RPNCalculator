namespace RPNCalculatorLib
{
    public class Division : IMathOperator
    {
        public double compute(double firstInput, double secondInput)
        {
            return firstInput / secondInput;
        }
    }
}
