using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    public class WindowsFormsCalculatorPresenter
    {

        private readonly WindowsFormsCalculatorModel _windowsFormsCalculatorModel = new WindowsFormsCalculatorModel();

        public string CalcPartA = "";
        public string CalcPartB = "";
        public char CalcOperator;
        public bool JustClickedOperator { get; set; }

        public WindowsFormsCalculatorView WindowsFormsCalculatorView
        {
            get;
            set;
        }

        public WindowsFormsCalculatorPresenter()
        {
            
        }

        public void AddToVariable(string input)
        {
            if (JustClickedOperator)
            {
                CalcPartB += input.ToString();
                WindowsFormsCalculatorView.textBoxOutput.Text += input.ToString();
            }
            else
            {
                CalcPartA += input.ToString();
                WindowsFormsCalculatorView.textBoxOutput.Text += input.ToString();
            }
        }

        public void ButtonEqual_Click()
        {
            var result = Interpret();
            JustClickedOperator = false;
            CalcPartA = result;
            WindowsFormsCalculatorView.textBoxOutput.Text = result;
            Console.WriteLine(result);
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
            CalcOperator = '+';
            CalcPartB = "";
            WindowsFormsCalculatorView.textBoxOutput.Text += "+";
        }

        public void ButtonMinus_Click()
        {
            if (JustClickedOperator)
            {
//                if (CalcPartB == "")
//                {
                    CalcPartB += "-";
                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
//                }
//                else
//                {
//
//                    ButtonEqual_Click();
//                    CalcPartB = "";
//                    JustClickedOperator = true;
//                    CalcOperator = '-';
//                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
//                }
            }
            else
            {
                if (CalcPartA == "")
                {
                    CalcPartA += "-";
                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
                }
                else
                {
                    JustClickedOperator = true;
                    CalcOperator = '-';
                    CalcPartB = "";
                    WindowsFormsCalculatorView.textBoxOutput.Text += "-";
                }
            }
        }

        public void ButtonMultipliedBy_Click()
        {
            if (JustClickedOperator)
            {
                ButtonEqual_Click();
                CalcPartB = "";
            }
            JustClickedOperator = true;
            CalcOperator = '*';
            CalcPartB = "";
            WindowsFormsCalculatorView.textBoxOutput.Text += "*";
        }

        public void ButtonDividedBy_Click()
        {
            if (JustClickedOperator)
            {
                ButtonEqual_Click();
                CalcPartB = "";
            }
            JustClickedOperator = true;
            CalcOperator = '/';
            CalcPartB = "";
            WindowsFormsCalculatorView.textBoxOutput.Text += "/";
        }

        public void ButtonClearLast_Click()
        {
            WindowsFormsCalculatorView.textBoxOutput.Text = WindowsFormsCalculatorView.textBoxOutput.Text.Substring(0, WindowsFormsCalculatorView.textBoxOutput.TextLength - 1);
            if (JustClickedOperator)
            {
                if (CalcPartB == "")
                {
                    JustClickedOperator = false;
                }

                else
                {
                    CalcPartB = CalcPartB.Substring(0, CalcPartB.Length - 1);
                }
            }
            else
            {
                CalcPartA = CalcPartA.Substring(0, CalcPartA.Length - 1);
            }
        }

        public void ButtonClear_Click()
        {
            JustClickedOperator = false;
            CalcPartA = "";
            CalcPartB = "";
            CalcOperator = default(char);
            WindowsFormsCalculatorView.textBoxOutput.Text = "";
        }

        public string Interpret()
        {
            switch (CalcOperator)
            {
                case '+':
                    return _windowsFormsCalculatorModel.sum(Double.Parse(CalcPartA), Double.Parse(CalcPartB)).ToString();
                    break;
                case '-':
                    return _windowsFormsCalculatorModel.subtract(Double.Parse(CalcPartA), Double.Parse(CalcPartB)).ToString();
                    break;
                case '*':
                    return _windowsFormsCalculatorModel.multiply(Double.Parse(CalcPartA), Double.Parse(CalcPartB)).ToString();
                    break;
                case '/':
                    return _windowsFormsCalculatorModel.divide(Double.Parse(CalcPartA), Double.Parse(CalcPartB)).ToString();
                    break;
                default:
                    return Double.Parse(CalcPartA).ToString();
            }
        }

//        public void parse(string input)
//        {
//            WindowsFormsCalculatorView.textBoxOutput.Text = _windowsFormsCalculatorModel.parse(input).ToString();
//        }
    }
}
