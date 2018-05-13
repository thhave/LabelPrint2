using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelEngine2.Presenters
{
    public interface INewTemplateView
    {
        string TemplateName { get; set; }
        int TemplateWidth { get; set; }
        int TemplateHeight { get; set; }

        NewTemplatePresenter Presenter { set; }

        void Show();
        void Close();
    }
}
