using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    public interface ICalculatorView
    {
        void SetOutput(string output);
        void AppendToOutput(string output);
    }
}
