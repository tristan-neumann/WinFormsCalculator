using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsCalculator;
using Moq;
using NUnit.Framework;

namespace WindowsFormsCalculatorTests
{
    [TestFixture]
    class WindowsFormsCalculatorPresenterTests
    {
        private WindowsFormsCalculatorPresenter _cut;

        [SetUp]
        public void SetUp()
        {
            _cut = new WindowsFormsCalculatorPresenter();
            _cut.WindowsFormsCalculatorView = new WindowsFormsCalculatorView(_cut);
        }

        public void ValueSetUp()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");
            _cut.AddToVariable("2");
            _cut.ButtonPlus_Click();
            _cut.AddToVariable("5");
        }

        [Test]
        public void ButtonPlus_ClickTest1()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");
            _cut.AddToVariable("2");

            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.ButtonPlus_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual('+', _cut.CalcOperator);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonPlus_ClickTest2()
        {
            ValueSetUp();

            Assert.IsTrue(_cut.JustClickedOperator);

            _cut.ButtonPlus_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonMinus_ClickAsOperatorTest()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");
            _cut.AddToVariable("2");

            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.ButtonMinus_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual('-', _cut.CalcOperator);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonMinus_ClickAsSignPartA()
        {
            _cut.ButtonMinus_Click();
            Assert.AreEqual("-", _cut.CalcPartA);
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");
            _cut.AddToVariable("2");

            Assert.AreEqual(default(char), _cut.CalcOperator);
            Assert.IsFalse(_cut.JustClickedOperator);
            Assert.AreEqual(default(char), _cut.CalcOperator);
            Assert.AreEqual("-1,2", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonMinus_ClickAsSignPartB()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");
            _cut.AddToVariable("2");
            _cut.ButtonMultipliedBy_Click();

            Assert.IsTrue(_cut.JustClickedOperator);

            _cut.ButtonMinus_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual('*', _cut.CalcOperator);
            Assert.AreEqual("1,2", _cut.CalcPartA);
            Assert.AreEqual("-", _cut.CalcPartB);

            _cut.AddToVariable("5");
        }

        [Test]
        public void ButtonMultipliedBy_ClickTest1()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");
            _cut.AddToVariable("2");

            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.ButtonMultipliedBy_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual('*', _cut.CalcOperator);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonMultipliedBy_ClickTest2()
        {
            ValueSetUp();

            Assert.IsTrue(_cut.JustClickedOperator);

            _cut.ButtonMultipliedBy_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonDividedBy_ClickTest1()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");
            _cut.AddToVariable("2");

            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.ButtonDividedBy_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual('/', _cut.CalcOperator);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonDividedBy_ClickTest2()
        {
            ValueSetUp();

            Assert.IsTrue(_cut.JustClickedOperator);

            _cut.ButtonDividedBy_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void AddToVariableTest()
        {
            Assert.IsFalse(_cut.JustClickedOperator);
            Assert.AreEqual("", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.AddToVariable("1");

            Assert.IsFalse(_cut.JustClickedOperator);
            Assert.AreEqual("1", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.AddToVariable(",");

            Assert.IsFalse(_cut.JustClickedOperator);
            Assert.AreEqual("1,", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.AddToVariable("2");

            Assert.IsFalse(_cut.JustClickedOperator);
            Assert.AreEqual("1,2", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
            Assert.AreEqual(default(char), _cut.CalcOperator);

            _cut.ButtonPlus_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual("1,2", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
            Assert.AreEqual('+', _cut.CalcOperator);

            _cut.AddToVariable("5");

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual("1,2", _cut.CalcPartA);
            Assert.AreEqual("5", _cut.CalcPartB);
            Assert.AreEqual('+', _cut.CalcOperator);
        }

        [Test]
        public void ButtonEqual_ClickTest1()
        {
            ValueSetUp();
            _cut.ButtonEqual_Click();

            Assert.IsFalse(_cut.JustClickedOperator);

            Assert.AreEqual("6,2", _cut.CalcPartA);
            Assert.AreEqual("6,2", _cut.WindowsFormsCalculatorView.textBoxOutput.Text);
        }

        [Test]
        public void ButtonEqual_ClickTest2()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable(",");

            Assert.AreEqual("1,", _cut.CalcPartA);
            Assert.AreEqual("1,", _cut.WindowsFormsCalculatorView.textBoxOutput.Text);
            Assert.AreEqual("", _cut.CalcPartB);

            _cut.ButtonEqual_Click();

            Assert.AreEqual("1", _cut.CalcPartA);
            Assert.AreEqual("1", _cut.WindowsFormsCalculatorView.textBoxOutput.Text);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonClear_ClickTest()
        {
            ValueSetUp();

            _cut.ButtonClear_Click();

            Assert.IsFalse(_cut.JustClickedOperator);
            Assert.AreEqual("", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
            Assert.AreEqual(default(char), _cut.CalcOperator);
        }

        [Test]
        public void ButtonClearLast_ClickTest1()
        {
            ValueSetUp();

            Assert.AreEqual("5", _cut.CalcPartB);

            _cut.ButtonClearLast_Click();

            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonClearLast_ClickTest2()
        {
            _cut.AddToVariable("1");
            _cut.ButtonPlus_Click();

            Assert.IsTrue(_cut.JustClickedOperator);
            Assert.AreEqual("1", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);

            _cut.ButtonClearLast_Click();

            Assert.IsFalse(_cut.JustClickedOperator);
            Assert.AreEqual("1", _cut.CalcPartA);
            Assert.AreEqual("", _cut.CalcPartB);
        }

        [Test]
        public void ButtonClearLast_ClickTest3()
        {
            _cut.AddToVariable("1");
            _cut.AddToVariable("2");

            Assert.AreEqual("12", _cut.CalcPartA);

            _cut.ButtonClearLast_Click();

            Assert.AreEqual("1", _cut.CalcPartA);
        }
    }
}
