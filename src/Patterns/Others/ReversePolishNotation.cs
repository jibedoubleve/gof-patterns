using System;
using System.Collections.Generic;

namespace Design.Patterns.Others
{
    public class ReversePolishNotation
    {
        #region Methods

        private double Calculate(double left, double right, string @operator)
        {
            switch (@operator.ToLower())
            {
                case "+": return left + right;
                case "-": return left - right;
                case "*": return left * right;
                case "/": return left / right;
                default: throw new NotSupportedException($"Operator '{@operator}' is not supported");
            }
        }

        public double Calculate(string expression)
        {
            var operations = expression.Split(' ');
            var stack = new Stack<double>();

            foreach (var item in operations)
            {
                if (double.TryParse(item, out var nbr)) { stack.Push(nbr); }
                else
                {
                    var left = stack.Pop();
                    var right = stack.Pop();
                    var result = Calculate(left, right, item);
                    stack.Push(result);
                }
            }

            return stack.Pop();
        }

        #endregion Methods
    }
}