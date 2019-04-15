using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsCalculator;
using Moq;
using NUnit.Framework;

namespace WindowsFormsCalculatorTests
{
    [TestFixture]
    public class CalculatorPresenterTests
    {
        private Mock<ICalculatorView> _calculatorViewMock;
        private CalculatorPresenter _cut;

        [SetUp]
        public void SetUp()
        {
            _calculatorViewMock = new Mock<ICalculatorView>();
            _cut = new CalculatorPresenter(_calculatorViewMock.Object);
        }

        [TestFixture]
        public class BasicFunctionalityTests : CalculatorPresenterTests
        {
            [Test]
            public void OnButtonPlusClickedTest()
            {
                _cut.OnButton3Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonPlusClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonEqualClicked();

                _calculatorViewMock.Verify(m => m.SetOutput("34"));
            }

            [Test]
            public void OnButtonMinusClickedTest()
            {
                _cut.OnButton3Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonMinusClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonEqualClicked();

                _calculatorViewMock.Verify(m => m.SetOutput("26"));
            }

            [Test]
            public void OnButtonMultipliedByClickedTest()
            {
                _cut.OnButton3Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonMultipliedByClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonEqualClicked();

                _calculatorViewMock.Verify(m => m.SetOutput("120"));
            }

            [Test]
            public void OnButtonDividedByClickedTest()
            {
                _cut.OnButton4Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonDividedByClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonEqualClicked();

                _calculatorViewMock.Verify(m => m.SetOutput("10"));
            }

            [Test]
            public void MultipleInputTest1()
            {
                _cut.OnButton3Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonMultipliedByClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonPlusClicked();

                _cut.OnButton5Clicked();

                _cut.OnButtonEqualClicked();
                _calculatorViewMock.Verify(m => m.SetOutput("125"));
            }

            [Test]
            public void MultipleInputTest2()
            {
                _cut.OnButton3Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonMultipliedByClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonMinusClicked();

                _cut.OnButton5Clicked();

                _cut.OnButtonEqualClicked();
                _calculatorViewMock.Verify(m => m.SetOutput("115"));
            }

            [Test]
            public void MultipleInputTest3()
            {
                _cut.OnButton3Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonMultipliedByClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonMultipliedByClicked();

                _cut.OnButton2Clicked();

                _cut.OnButtonEqualClicked();
                _calculatorViewMock.Verify(m => m.SetOutput("240"));
            }

            [Test]
            public void MultipleInputTest4()
            {
                _cut.OnButton3Clicked();
                _cut.OnButton0Clicked();

                _cut.OnButtonMultipliedByClicked();

                _cut.OnButton4Clicked();

                _cut.OnButtonDividedByClicked();

                _cut.OnButton6Clicked();

                _cut.OnButtonEqualClicked();
                _calculatorViewMock.Verify(m => m.SetOutput("20"));
            }

            [Test]
            public void OnButtonDecimalSeparatorClickedTest()
            {
                _cut.OnButton2Clicked();
                _cut.OnButtonDecimalSeparatorClicked();
                _cut.OnButton5Clicked();

                _cut.OnButtonMultipliedByClicked();
                _cut.OnButton2Clicked();

                _cut.OnButtonEqualClicked();

                _calculatorViewMock.Verify(m => m.SetOutput("5"));
            }

            [Test]
            public void OnButtonEqualClickedTest()
            {
                _cut.OnButtonEqualClicked();
                _calculatorViewMock.Verify(m => m.SetOutput("0"));
            }

            [Test]
            public void OnButtonEqualTwiceClickedTest()
            {
                _cut.OnButton2Clicked();
                _cut.OnButtonEqualClicked();
                _cut.OnButtonEqualClicked();

                _calculatorViewMock.Verify(m => m.SetOutput("2"));
            }
        }

        [TestFixture]
        public class BasicViewTests : CalculatorPresenterTests
        {
            [Test]
            public void AppendOutputTest0()
            {
                _cut.OnButton0Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("0"));
            }

            [Test]
            public void AppendOutputTest1()
            {
                _cut.OnButton1Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("1"));
            }

            [Test]
            public void AppendOutputTest2()
            {
                _cut.OnButton2Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("2"));
            }

            [Test]
            public void AppendOutputTest3()
            {
                _cut.OnButton3Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("3"));
            }

            [Test]
            public void AppendOutputTest4()
            {
                _cut.OnButton4Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("4"));
            }

            [Test]
            public void AppendOutputTest5()
            {
                _cut.OnButton5Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("5"));
            }

            [Test]
            public void AppendOutputTest6()
            {
                _cut.OnButton6Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("6"));
            }

            [Test]
            public void AppendOutputTest7()
            {
                _cut.OnButton7Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("7"));
            }

            [Test]
            public void AppendOutputTest8()
            {
                _cut.OnButton8Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("8"));
            }

            [Test]
            public void AppendOutputTest9()
            {
                _cut.OnButton9Clicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("9"));
            }

            [Test]
            public void AppendOutputPlusTest()
            {
                _cut.OnButton0Clicked();
                _cut.OnButtonPlusClicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("+"));
            }

            [Test]
            public void AppendOutputMinusTest()
            {
                _cut.OnButton0Clicked();
                _cut.OnButtonMinusClicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("-"));
            }

            [Test]
            public void AppendOutputMultipliedByTest()
            {
                _cut.OnButton0Clicked();
                _cut.OnButtonMultipliedByClicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("*"));
            }

            [Test]
            public void AppendOutputDividedByTest()
            {
                _cut.OnButton0Clicked();
                _cut.OnButtonDividedByClicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput("/"));
            }

            [Test]
            public void AppendOutputDecimalSeparatorTest()
            {
                _cut.OnButton0Clicked();
                _cut.OnButtonDecimalSeparatorClicked();
                _calculatorViewMock.Verify(m => m.AppendToOutput(NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
            }
        }
    }
}
