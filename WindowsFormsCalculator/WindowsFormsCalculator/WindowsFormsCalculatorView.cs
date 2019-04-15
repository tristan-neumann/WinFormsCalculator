using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class WindowsFormsCalculatorView : Form, ICalculatorView
    {
        private readonly ICalculatorPresenter _calculatorPresenter;

        public WindowsFormsCalculatorView()
        {
            _calculatorPresenter = new  CalculatorPresenter(this);
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton0Clicked();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton1Clicked();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton2Clicked();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton3Clicked();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton4Clicked();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton5Clicked();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton6Clicked();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton7Clicked();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton8Clicked();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButton9Clicked();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButtonDecimalSeparatorClicked();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
           _calculatorPresenter.OnButtonEqualClicked();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButtonPlusClicked();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButtonMinusClicked();
        }

        private void buttonMultipliedBy_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButtonMultipliedByClicked();
        }

        private void buttonDividedBy_Click(object sender, EventArgs e)
        {
            _calculatorPresenter.OnButtonDividedByClicked();
        }

        private void buttonClearLast_Click(object sender, EventArgs e)
        {
//            _windowsFormsCalculatorPresenter.ButtonClearLast_Click();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
//            _windowsFormsCalculatorPresenter.ButtonClear_Click();
        }

        public void SetOutput(string output)
        {
            textBoxOutput.Text = output;
        }

        public void AppendToOutput(string output)
        {
            textBoxOutput.Text += output;
        }

        public void PrependToOutput(string output)
        {
            textBoxOutput.Text = "-" + textBoxOutput.Text;
        }
    }
}
