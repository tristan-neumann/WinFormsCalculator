using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    public interface IWindowsFormsCalculatorModel
    {
        double sum(double a, double b);
        double subtract(double a, double b);
        double multiply(double a, double b);
        double divide(double a, double b);
    }

    public class WindowsFormsCalculatorModel : IWindowsFormsCalculatorModel
    {

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
