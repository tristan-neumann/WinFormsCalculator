namespace WindowsFormsCalculator
{
    public interface ICalculatorArithmeticUnit
    {
        CalcOperator Operation { get; set; }
        double Number { get; set; }

        void CalculateResult(double value);
    }
}