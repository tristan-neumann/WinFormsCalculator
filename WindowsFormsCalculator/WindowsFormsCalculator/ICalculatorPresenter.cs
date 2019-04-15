using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    public interface ICalculatorPresenter
    {
        void OnButton0Clicked();
        void OnButton1Clicked();
        void OnButton2Clicked();
        void OnButton3Clicked();
        void OnButton4Clicked();
        void OnButton5Clicked();
        void OnButton6Clicked();
        void OnButton7Clicked();
        void OnButton8Clicked();
        void OnButton9Clicked();

        void OnButtonDecimalSeparatorClicked();

        void OnButtonNegationClicked();

        void OnButtonPlusClicked();
        void OnButtonMinusClicked();
        void OnButtonMultipliedByClicked();
        void OnButtonDividedByClicked();

        void OnButtonEqualClicked();
    }
}
