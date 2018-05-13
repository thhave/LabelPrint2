using System;
using System.Drawing;

namespace LabelEngine2.Models
{
    class LabelRenderer : ILabelRenderer
    {
        private Graphics graphics;
        private Image image;
        private bool rendered = false;

        public Image Image
        {
            get
            {
                if (!rendered)
                    throw new Exception("Обращение к изображению до рендеринга");
                return image;
            }
        }

        public ITemplate Template { get; set; }

        public void Render()
        {
            foreach (var entry in Template.Fields)
            {
                var field = Template.Fields[entry.Key];
                RectangleF absolutePosition = field.GetAbsolutePosition(image.Width, image.Height);
                Font font = new Font(field.FontName, field.FontSize * image.Width / 300);
                graphics.DrawString(field.Text, font, new SolidBrush(Color.Black), absolutePosition, field.Format);
            }
            rendered = true;
        }

        public LabelRenderer(ITemplate template)
        {
            Template = template;
            image = new Bitmap(Convert.ToInt32(Template.Size.Width),
                               Convert.ToInt32(Template.Size.Height));
            graphics = Graphics.FromImage(image);
            rendered = false;
        }

        public LabelRenderer(ITemplate template, Color backgroundColor) : this(template)
        {
            graphics.FillRectangle(new SolidBrush(backgroundColor), new Rectangle(0, 0, image.Size.Width, image.Size.Height));
        }
    }
}
