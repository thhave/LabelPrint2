using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabelEngine2.Models
{
    public interface ILabelRenderer
    {
        Image Image { get; }
        ITemplate Template { get; set; }
        void Render();

    }
}
