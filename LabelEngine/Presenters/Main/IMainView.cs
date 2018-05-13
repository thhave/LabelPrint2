using System.Collections.Generic;
using System.Drawing;
using System.Data;

namespace LabelEngine2.Presenters
{
    public interface IMainView
    {
        DataTable Data { get; set; } //Таблица данных 
        string SearchQuery { get; set;  }
        Image Preview { get; set; } //Превью этикетки
        List<string> TemplateList { get; set; } //Список шаблонов
        List<string> ColumnList { get; set; } //Список имен столбцов

        void Show(); //Показать форму и запустить цикл обработки Windows событий  Application.Run(new Form())
        void Close(); //Закрытие формы

        MainPresenter Presenter { set; } //Свойство для передачи ссылки на презентер в форму
    }
}
