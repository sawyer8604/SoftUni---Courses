using System;
using System.Collections.Generic;
using System.Text;

namespace Solving_math_expressions_with_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var expression = "((1+2+2)*3-100)/2";

            double result = Evaluate(expression);

            Console.WriteLine(result);
        }

        static double Evaluate(string expression)
        {
            string allowedOperators = "+-/*^";

            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {

                char symbol = expression[i];

                if (symbol == '(')
                {
                    operators.Push(symbol);
                }
                else if (symbol == ')')
                {

                    while (operators.Peek() != '(')
                    {
                        char op = operators.Pop();
                        double param2 = numbers.Pop();
                        double param1 = numbers.Pop();
                        double newValue = ApplyOperation(op, param1, param2);
                        numbers.Push(newValue);
                    }
                    operators.Pop();
                }
                else if (allowedOperators.Contains(symbol))
                {
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(symbol))
                    {
                        char op = operators.Pop();
                        double param2 = numbers.Pop();
                        double param1 = numbers.Pop();
                        double newValue = ApplyOperation(op, param1, param2);
                        numbers.Push(newValue);
                    }

                    operators.Push(symbol);
                }
                else if (char.IsDigit(symbol) || symbol == '.')
                {
                    StringBuilder number = new StringBuilder();

                    while (char.IsDigit(symbol) || symbol == '.')
                    {
                        number.Append(symbol);

                        i++;

                        if (i == expression.Length)
                        {
                            break;
                        }

                        symbol = expression[i];

                    }

                    i--;

                    numbers.Push(double.Parse(number.ToString()));
                }

            }

            while (operators.Count > 0)
            {
                char op = operators.Pop();
                double param2 = numbers.Pop();
                double param1 = numbers.Pop();
                double newValue = ApplyOperation(op, param1, param2);
                numbers.Push(newValue);
            }

            return numbers.Pop();
        }

        static double ApplyOperation(char operation, double operand1, double operand2)
        {

            switch (operation)
            {
                case '+': return operand1 + operand2;
                case '-': return operand1 - operand2;
                case '*': return operand1 * operand2;
                case '/': return operand1 / operand2;
                case '^': return Math.Pow(operand1, operand2);

                default: return 0;
            }
        }

        static int Priority (char operation)
        {
            switch (operation)
            {
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                case '^': return 3;

                default: return 0;
            }
        }
    }
}
