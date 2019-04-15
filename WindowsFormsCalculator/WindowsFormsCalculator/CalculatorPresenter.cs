using System;
using System.Globalization;

namespace WindowsFormsCalculator
{
    public class CalculatorPresenter : ICalculatorPresenter
    {
        private enum CalcOperator
        {
            Plus, Minus, DividedBy, MultipliedBy, Empty
        }

        private readonly ICalculatorView _calculatorView;
        private string _numberString;
        private double _number;
        private CalcOperator _calcOperator;

        public CalculatorPresenter(ICalculatorView calculatorView)
        {
            _calculatorView = calculatorView;
        }


        public void OnButton0Clicked()
        {
            _numberString += "0";
            _calculatorView.AppendToOutput("0");
        }

        public void OnButton1Clicked()
        {
            _numberString += "1";
            _calculatorView.AppendToOutput("1");
        }

        public void OnButton2Clicked()
        {
            _numberString += "2";
            _calculatorView.AppendToOutput("2");
        }

        public void OnButton3Clicked()
        {
            _numberString += "3";
            _calculatorView.AppendToOutput("3");
        }

        public void OnButton4Clicked()
        {
            _numberString += "4";
            _calculatorView.AppendToOutput("4");
        }

        public void OnButton5Clicked()
        {
            _numberString += "5";
            _calculatorView.AppendToOutput("5");
        }

        public void OnButton6Clicked()
        {
            _numberString += "6";
            _calculatorView.AppendToOutput("6");
        }

        public void OnButton7Clicked()
        {
            _numberString += "7";
            _calculatorView.AppendToOutput("7");
        }

        public void OnButton8Clicked()
        {
            _numberString += "8";
            _calculatorView.AppendToOutput("8");
        }

        public void OnButton9Clicked()
        {
            _numberString += "9";
            _calculatorView.AppendToOutput("9");
        }

        public void OnButtonPlusClicked()
        {
            CalculateResult();
            _calcOperator = CalcOperator.Plus;
            _calculatorView.AppendToOutput("+");
        }

        public void OnButtonMinusClicked()
        {
            CalculateResult();
            _calcOperator = CalcOperator.Minus;
            _calculatorView.AppendToOutput("-");
        }

        public void OnButtonMultipliedByClicked()
        {
            CalculateResult();
            _calcOperator = CalcOperator.MultipliedBy;
            _calculatorView.AppendToOutput("*");
        }

        public void OnButtonDividedByClicked()
        {
            CalculateResult();
            _calcOperator = CalcOperator.DividedBy;
            _calculatorView.AppendToOutput("/");
        }

        public void OnButtonEqualClicked()
        {
            CalculateResult();
        }

        private void CalculateResult()
        {
            var number = double.Parse(_numberString);
            _numberString = string.Empty;

            switch (_calcOperator)
            {
                case CalcOperator.Plus:
                    _number += number;
                    break;
                case CalcOperator.Minus:
                    _number -= number;
                    break;
                case CalcOperator.DividedBy:
                    _number /= number;
                    break;
                case CalcOperator.MultipliedBy:
                    _number *= number;
                    break;
                case CalcOperator.Empty:
                    _number = number;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            _calculatorView.SetOutput(_number.ToString(CultureInfo.InvariantCulture));
        }
    }
}