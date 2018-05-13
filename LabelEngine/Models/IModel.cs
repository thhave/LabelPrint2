using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelEngine2.Models
{
    public enum MovementDirection { Up, Down, Left, Right, UpRight, UpLeft, DownRight, DownLeft } //Направление для перемещения полей шаблонов
    public enum SizeChanges { IncreaseFieldWidth, DecreaseFieldWidth, IncreaseFieldHeight, DecreaseFieldHeight } //Действия с размером поля

    public interface IModel
    {
        ILabelRepository Repository { get; set; }
        IDataProvider DataProvider { get; set; }
        IPrinter Printer { get; set; }
        AppConfig Config { get; }

        void SaveState();
    }
}
