namespace RPNCalculatorLib
{
    using System;

    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)]
    public class MathOperatorAttribute : Attribute
    {
        public string MathOperator { get; private set; }

        public MathOperatorAttribute(string mathOperator)
        {
            this.MathOperator = mathOperator;
        }
    }
}
