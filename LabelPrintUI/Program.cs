using System;
using System.Windows.Forms;
using LabelEngine2.Presenters;
using LabelEngine2.Models;

namespace LabelPrintUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var model = new Model();
            var mainFormPresenter = new MainPresenter(new mainForm(), model);
            mainFormPresenter.Run();
        }
    }
}
