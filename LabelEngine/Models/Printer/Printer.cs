using System.Drawing;
using System.Drawing.Printing;

namespace LabelEngine2.Models
{
    public class Printer : IPrinter
    {
        private PrintDocument document;
        private Image image; //Печатаемое изображение

        public Printer(string printerName, bool landscape = false)
        {
            document = new PrintDocument();
            document.PrinterSettings.PrinterName = printerName; //Имя принтера
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            document.DefaultPageSettings.Landscape = landscape; //Ориентация     
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int margin = 0;
            int marginW = 0;
            int marginH = 0;
            //Границы печати
            Rectangle customBounds = new Rectangle(e.PageBounds.X + margin,
                                                   e.PageBounds.Y + margin,
                                                   e.PageBounds.Width - marginW,
                                                   e.PageBounds.Height - marginH);
            e.Graphics.DrawImage(image, customBounds); //Печатать изображение с масштабом до границ страницы (100% заполнение)
        }

        public void Print(Image img)
        {
            this.image = img;
            document.Print(); //Печать
        }

        public float PaperRatio //Получение соотношений сторон бумаги (отношение ширины к высоте)
        {
            get
            {
                //Соотношение сторон
                float ratio = document.DefaultPageSettings.PaperSize.Width / document.DefaultPageSettings.PaperSize.Height;
                //Вернуть 1, если соотношение равно нулю (из-за некорректных полученных выше значений размеров бумаги):
                return ratio == 0 ? 1 : ratio;
            }
        }
    }
}
