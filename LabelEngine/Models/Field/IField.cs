using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabelEngine2.Models
{
    public interface IField
    {
        RectangleF RelativePosition { get; set; }
        RectangleF GetAbsolutePosition(float width, float height);
        string Text { get; set; }
        string FontName { get; set; }
        float FontSize { get; set; }
        StringFormat Format { get; set; }
    }
}
