using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    public class WindowsFormsCalculatorPresenter
    {

        private WindowsFormsCalculatorModel _windowsFormsCalculatorModel;

        private string _calcPartA = "";
        private string _calcPartB = "";
        private char _calcOperator;
        public bool JustClickedOperator { get; set; }

        public WindowsFormsCalculatorView WindowsFormsCalculatorView
        {
            get;
            set;
        }

        public WindowsFormsCalculatorPresenter(WindowsFormsCalculatorModel windowsFormsCalculatorModel)
        {
            _windowsFormsCalculatorModel = windowsFormsCalculatorModel;
        }

        public void AddToVariable(string input)
        {
            if (JustClickedOperator)
            {
                _calcPartB += input.ToString();
                WindowsFormsCalculatorView.textBoxOutput.Text += input.ToString();
            }
            else
            {
                _calcPartA += input.ToString();
                WindowsFormsCalculatorView.textBoxOutput.Text += input.ToString();
            }
        }

        public void ButtonEqual_Click()
        {
            Interpret();
            JustClickedOperator = false;
            _calcPartA = WindowsFormsCalculatorView.textBoxOutput.Text;
            //            _calcPartB = "";
            //            _calcOperator = 'n';
        }

        public void ButtonPlus_Click()
        {
            if (JustClickedOperator)
            {
                ButtonEqual_Click();
            }
            JustClickedOperator = true;
            _calcOperator = '+';
            _calcPartB = "";
            WindowsFormsCalculatorView.textBoxOutput.Text += "+";
        }

        public void ButtonMinus_Click()
        {
            if (JustClickedOperator)
            {
                if (_calcPartB == "")
                {
                    _calcPartB += "-";
                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
                }
                else
                {

                    ButtonEqual_Click();
                    _calcPartB = "";
                    JustClickedOperator = true;
                    _calcOperator = '-';
                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
                }
            }
            else
            {
                if (_calcPartA == "")
                {
                    _calcPartA += "-";
                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
                }
                else
                {
                    JustClickedOperator = true;
                    _calcOperator = '-';
                    _calcPartB = "";
                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
                }
            }
        }

        public void ButtonMultipliedBy_Click()
        {
            if (JustClickedOperator)
            {
                ButtonEqual_Click();
                _calcPartB = "";
            }
            JustClickedOperator = true;
            _calcOperator = '*';
            _calcPartB = "";
            WindowsFormsCalculatorView.textBoxOutput.Text += "*";
        }

        public void ButtonDividedBy_Click()
        {
            if (JustClickedOperator)
            {
                ButtonEqual_Click();
                _calcPartB = "";
            }
            JustClickedOperator = true;
            _calcOperator = '/';
            _calcPartB = "";
            WindowsFormsCalculatorView.textBoxOutput.Text += "/";
        }

        public void ButtonClearLast_Click()
        {
            WindowsFormsCalculatorView.textBoxOutput.Text = WindowsFormsCalculatorView.textBoxOutput.Text.Substring(0, WindowsFormsCalculatorView.textBoxOutput.TextLength - 1);
            if (JustClickedOperator)
            {
                if (_calcPartB == "")
                {
                    JustClickedOperator = false;
                }

                else
                {
                    _calcPartB = _calcPartB.Substring(0, _calcPartB.Length - 1);
                }
            }
            else
            {
                _calcPartA = _calcPartA.Substring(0, _calcPartA.Length - 1);
            }
        }

        public void ButtonClear_Click()
        {
            JustClickedOperator = false;
            _calcPartA = "";
            _calcPartB = "";
            _calcOperator = 'n';
            WindowsFormsCalculatorView.textBoxOutput.Text = "";
        }

        public void Interpret()
        {
            switch (_calcOperator)
            {
                case '+':
                    WindowsFormsCalculatorView.textBoxOutput.Text =
                        _windowsFormsCalculatorModel.sum(Double.Parse(_calcPartA), Double.Parse(_calcPartB)).ToString();
                    break;
                case '-':
                    WindowsFormsCalculatorView.textBoxOutput.Text =
                        _windowsFormsCalculatorModel.subtract(Double.Parse(_calcPartA), Double.Parse(_calcPartB)).ToString();
                    break;
                case '*':
                    WindowsFormsCalculatorView.textBoxOutput.Text =
                        _windowsFormsCalculatorModel.multiply(Double.Parse(_calcPartA), Double.Parse(_calcPartB)).ToString();
                    break;
                case '/':
                    WindowsFormsCalculatorView.textBoxOutput.Text =
                        _windowsFormsCalculatorModel.divide(Double.Parse(_calcPartA), Double.Parse(_calcPartB)).ToString();
                    break;
            }
        }

        public void parse(string input)
        {
            WindowsFormsCalculatorView.textBoxOutput.Text = _windowsFormsCalculatorModel.parse(input).ToString();
        }
    }
}
