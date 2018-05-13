using System.Collections.Generic;
using System.Drawing;

namespace LabelEngine2.Models
{

    public interface ITemplate
    {
        Dictionary<string, IField> Fields { get; set; }
        SizeF Size { get; set; }
    }
}
