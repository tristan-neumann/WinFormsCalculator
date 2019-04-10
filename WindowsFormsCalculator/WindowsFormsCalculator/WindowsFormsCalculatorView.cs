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
    public partial class WindowsFormsCalculatorView : Form
    {
        private readonly WindowsFormsCalculatorPresenter _windowsFormsCalculatorPresenter;


        public WindowsFormsCalculatorView(WindowsFormsCalculatorPresenter windowsFormsCalculatorPresenter)
        {
            _windowsFormsCalculatorPresenter = windowsFormsCalculatorPresenter;
            _windowsFormsCalculatorPresenter.WindowsFormsCalculatorView = this;
            _windowsFormsCalculatorPresenter.JustClickedOperator = false;
            InitializeComponent();
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddToVariable(int input)
        {
            _windowsFormsCalculatorPresenter.AddToVariable(input.ToString());
        }
        

        private void button0_Click(object sender, EventArgs e)
        {
            AddToVariable(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToVariable(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToVariable(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToVariable(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToVariable(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToVariable(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToVariable(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToVariable(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToVariable(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddToVariable(9);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            _windowsFormsCalculatorPresenter.AddToVariable(",");
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            _windowsFormsCalculatorPresenter.ButtonEqual_Click();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _windowsFormsCalculatorPresenter.ButtonPlus_Click();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _windowsFormsCalculatorPresenter.ButtonMinus_Click();
        }

        private void buttonMultipliedBy_Click(object sender, EventArgs e)
        {
           _windowsFormsCalculatorPresenter.ButtonMultipliedBy_Click();
        }

        private void buttonDividedBy_Click(object sender, EventArgs e)
        {
           _windowsFormsCalculatorPresenter.ButtonDividedBy_Click();
        }

        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            _windowsFormsCalculatorPresenter.ButtonClearLast_Click();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _windowsFormsCalculatorPresenter.ButtonClear_Click();
        }
    }
}
