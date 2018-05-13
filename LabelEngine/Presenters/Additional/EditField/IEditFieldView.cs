using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabelEngine2.Presenters
{
    public interface IEditFieldView
    {
        string FieldName { get; set; }
        string Data { get; set; }
        string EditingTemplateName { set; }
        string EditingFieldName { set; }

        Font FieldFont { get; set; }

        EditFieldPresenter Presenter { set; }

        void Show(bool editingMode = false);
        void Close();
    }
}
