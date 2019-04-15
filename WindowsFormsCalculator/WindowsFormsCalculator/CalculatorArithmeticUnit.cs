using System;

namespace WindowsFormsCalculator
{
    public class CalculatorArithmeticUnit : ICalculatorArithmeticUnit
    {
        public CalcOperator Operation { get; set; }

        public double Number { get; set; }

        public void CalculateResult(double value)
        {
            switch (Operation)
            {
                case CalcOperator.Plus:
                    Number += value;
                    break;
                case CalcOperator.Minus:
                    Number -= value;
                    break;
                case CalcOperator.DividedBy:
                    Number /= value;
                    break;
                case CalcOperator.MultipliedBy:
                    Number *= value;
                    break;
                case CalcOperator.Empty:
                    Number = value;
                    break;
                case CalcOperator.Negation:
                    Number = -Number;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}