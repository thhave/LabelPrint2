using System.Drawing;

namespace LabelEngine2.Models
{
    public interface IPrinter
    {
        void Print(Image img);
        float PaperRatio { get; }
    }
}
