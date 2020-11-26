namespace RPNCalculatorLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class MathFactory
    {
        static Dictionary<string, Type> mathOperators;
        static MathFactory()
        {
            Initialize();
        }

        private static void Initialize()
        {
            Type attributeType = typeof(MathOperatorAttribute);
            var mathOperatorAtrributes = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                         from type in assembly.GetTypes()
                                         let attributes = type.GetCustomAttributes(attributeType, true)
                                         where attributes.Any()
                                         select
                                             new KeyValuePair<String, Type>(((MathOperatorAttribute)attributes.First())
                                             .MathOperator, type);

            mathOperators = new Dictionary<string, Type>();
            foreach (var item in mathOperatorAtrributes)
                mathOperators.Add(item.Key, item.Value);
        }

        public static IMathOperator GetMathObject(string mathOperator)
        {
            IMathOperator mathOperation = null;

            if (mathOperator.Equals("+"))
            {
                mathOperation = new Addition();
            }
            else if (mathOperator.Equals("-"))
            {
                mathOperation = new Subtraction();
            }
            else if (mathOperator.Equals("*"))
            {
                mathOperation = new Multiplication();
            }
            else if (mathOperator.Equals("/"))
            {
                mathOperation = new Division();
            }

            return mathOperation;
        }

        public static IMathOperator GetMathObjectByReflection(string mathOperator)
        {
            IMathOperator mathOperation = (IMathOperator)Activator.CreateInstance(mathOperators[mathOperator]);
            return mathOperation;
        }
    }
}
