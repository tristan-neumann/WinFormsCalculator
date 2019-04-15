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
        double BuildAndReset();
    }

    public class NumberBuilder : INumberBuilder
    {
        private string _numberString = string.Empty;

        public void AddDigit0()
        {
            _numberString += 0;
        }

        public void AddDigit1()
        {
            _numberString += 1;

        }

        public void AddDigit2()
        {
            _numberString += 2;

        }

        public void AddDigit3()
        {
            _numberString += 3;

        }

        public void AddDigit4()
        {
            _numberString += 4;

        }

        public void AddDigit5()
        {
            _numberString += 5;

        }

        public void AddDigit6()
        {
            _numberString += 6;

        }

        public void AddDigit7()
        {
            _numberString += 7;

        }

        public void AddDigit8()
        {
            _numberString += 8;

        }

        public void AddDigit9()
        {
            _numberString += 9;

        }

        public double BuildAndReset()
        {
            var number = double.Parse(_numberString);
            _numberString = string.Empty;
            return number;
        }
    }
}