using System;

namespace WindowsFormsCalculator
{
    public interface INumberBuilder
    {
        void AddDigit0();
        void AddDigit1();
        void AddDigit2();
        void AddDigit3();
        void AddDigit4();
        void AddDigit5();
        void AddDigit6();
        void AddDigit7();
        void AddDigit8();
        void AddDigit9();

        bool ContainsDecimalSeparator { get;  }

        bool AddDecimalSeparator();

        double BuildAndReset();
    }
}