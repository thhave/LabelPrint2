using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabelEngine2.Presenters
{
    public interface ISettingsView
    {

        SettingsPresenter Presenter { set; }
        List<string> PrinterList { get; set; }
        string TemplatesFolderPath { get; set; }
        Image Preview { get; set; } //Превью редактируемого шаблона
        List<string> TemplateList { get; set; } //Список шаблонов
        List<string> SelectedTemplateFieldList { get; set; }
        float FieldWidth { get; set; }
        float FieldHeight { get; set; }

        void Show(); //Показать форму и запустить цикл обработки Windows событий  Application.Run(new Form())
        void Close(); //Закрытие формы
    }
}
