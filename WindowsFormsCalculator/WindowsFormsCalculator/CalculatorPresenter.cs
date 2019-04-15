using System.Globalization;

namespace WindowsFormsCalculator
{
    public class CalculatorPresenter : ICalculatorPresenter
    {
        private readonly ICalculatorArithmeticUnit _calculatorArithmeticUnit = new CalculatorArithmeticUnit();
        private readonly ICalculatorView _calculatorView;
        private readonly INumberBuilder _numberBuilder = new NumberBuilder();

        public CalculatorPresenter(ICalculatorView calculatorView)
        {
            _calculatorView = calculatorView;
        }

        public void OnButton0Clicked()
        {
            _numberBuilder.AddDigit0();
            _calculatorView.AppendToOutput("0");
        }

        public void OnButton1Clicked()
        {
            _numberBuilder.AddDigit1();
            _calculatorView.AppendToOutput("1");
        }

        public void OnButton2Clicked()
        {
            _numberBuilder.AddDigit2();
            _calculatorView.AppendToOutput("2");
        }

        public void OnButton3Clicked()
        {
            _numberBuilder.AddDigit3();
            _calculatorView.AppendToOutput("3");
        }

        public void OnButton4Clicked()
        {
            _numberBuilder.AddDigit4();
            _calculatorView.AppendToOutput("4");
        }

        public void OnButton5Clicked()
        {
            _numberBuilder.AddDigit5();
            _calculatorView.AppendToOutput("5");
        }

        public void OnButton6Clicked()
        {
            _numberBuilder.AddDigit6();
            _calculatorView.AppendToOutput("6");
        }

        public void OnButton7Clicked()
        {
            _numberBuilder.AddDigit7();
            _calculatorView.AppendToOutput("7");
        }

        public void OnButton8Clicked()
        {
            _numberBuilder.AddDigit8();
            _calculatorView.AppendToOutput("8");
        }

        public void OnButton9Clicked()
        {
            _numberBuilder.AddDigit9();
            _calculatorView.AppendToOutput("9");
        }

        public void OnButtonDecimalSeparatorClicked()
        {
            _numberBuilder.AddDecimalSeparator();

            _calculatorView.AppendToOutput(",");
        }

        public void OnButtonPlusClicked()
        {
            CalculateResult();
            _calculatorArithmeticUnit.Operation = CalcOperator.Plus;
            _calculatorView.AppendToOutput("+");
        }

        public void OnButtonMinusClicked()
        {
            CalculateResult();
            _calculatorArithmeticUnit.Operation = CalcOperator.Minus;
            _calculatorView.AppendToOutput("-");
        }

        public void OnButtonMultipliedByClicked()
        {
            CalculateResult();
            _calculatorArithmeticUnit.Operation = CalcOperator.MultipliedBy;
            _calculatorView.AppendToOutput("*");
        }

        public void OnButtonDividedByClicked()
        {
            CalculateResult();
            _calculatorArithmeticUnit.Operation = CalcOperator.DividedBy;
            _calculatorView.AppendToOutput("/");
        }

        public void OnButtonEqualClicked()
        {
            CalculateResult();
        }

        private void CalculateResult()
        {
            var number = _numberBuilder.BuildAndReset();

            _calculatorArithmeticUnit.CalculateResult(number);

            _calculatorView.SetOutput(_calculatorArithmeticUnit.Number.ToString(CultureInfo.InvariantCulture));
        }
    }
}