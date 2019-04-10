using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    static class Program
    {
        private static WindowsFormsCalculatorPresenter _windowsFormsCalculatorPresenter;
        private static WindowsFormsCalculatorView _windowsFormsCalculatorView;
        private static WindowsFormsCalculatorModel _windowsFormsCalculatorModel;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _windowsFormsCalculatorModel = new WindowsFormsCalculatorModel();
            _windowsFormsCalculatorPresenter = new WindowsFormsCalculatorPresenter(_windowsFormsCalculatorModel);
            _windowsFormsCalculatorView = new WindowsFormsCalculatorView(_windowsFormsCalculatorPresenter);

            Application.Run(_windowsFormsCalculatorView);
        }
    }
}
