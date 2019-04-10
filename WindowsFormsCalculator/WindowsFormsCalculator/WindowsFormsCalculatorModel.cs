using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    public class WindowsFormsCalculatorModel
    {

        public double parse(string input)
        {
            if (input.Contains("X"))
            {
                var splitResult = input.Split('X');

                return Double.Parse(splitResult[0]) * Double.Parse(splitResult[1]);
            }
            else if (input.Contains("/"))
            {
                var splitResult = input.Split('/');

                return Double.Parse(splitResult[0]) / Double.Parse(splitResult[1]);
            }
            else if (input.Contains("+"))
            {
                var splitResult = input.Split('+');

                return Double.Parse(splitResult[0]) + Double.Parse(splitResult[1]);
            }
            else if (input.Contains("-"))
            {
                if (input[0] == '-')
                {
                    input = input.Substring(1);
                }
                var splitResult = input.Split('-');

                if (input.Contains("-")) {
                    return -Double.Parse(splitResult[0]) - Double.Parse(splitResult[1]);
                }
                else
                {
                    return -Double.Parse(input);
                }
            }
            else
            {
                return Double.Parse(input);
            }
        }

        public double sum(double a, double b)
        {
            return (a + b);
        }

        public double subtract(double a, double b)
        {
            return (a - b);
        }

        public double multiply(double a, double b)
        {
            return (a * b);
        }

        public double divide(double a, double b)
        {
            return (a / b);
        }
    }
}
