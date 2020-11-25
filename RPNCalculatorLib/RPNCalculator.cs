﻿namespace RPNCalculatorLib
{
    using System;
    using System.Collections.Generic;

    public class RPNCalculator
    {
        private double firstNumber, secondNumber, result;
        private Stack<double> numberStack;
        public RPNCalculator()
        {
            numberStack = new Stack<double>();
        }
        public double compute(string rpnMathExpression)
        {

            string[] rpnTokens = rpnMathExpression.Split(' ');

            foreach ( var token in rpnTokens )
            {
                if ( token.Equals("+") )
                {
                    Add();

                    numberStack.Push(result);
                }
                else if (token.Equals("-"))
                {
                    secondNumber = numberStack.Pop();
                    firstNumber = numberStack.Pop();

                    result = firstNumber - secondNumber;

                    numberStack.Push(result);
                }
                else if (token.Equals("*"))
                {
                    secondNumber = numberStack.Pop();
                    firstNumber = numberStack.Pop();

                    result = firstNumber * secondNumber;

                    numberStack.Push(result);
                }
                else if (token.Equals("/"))
                {
                    secondNumber = numberStack.Pop();
                    firstNumber = numberStack.Pop();

                    result = firstNumber / secondNumber;

                    numberStack.Push(result);
                }
                else
                {
                    numberStack.Push(Convert.ToDouble(token));
                }
            }

            return numberStack.Pop();
        }

        private void Add()
        {
            secondNumber = numberStack.Pop();
            firstNumber = numberStack.Pop();

            result = firstNumber + secondNumber;
        }
    }
}
