using System;
using System.Drawing;
using Newtonsoft.Json;

namespace LabelEngine2.Models
{
    [Serializable]
    class Field : IField
    {
        [JsonPropertyAttribute]
        public RectangleF RelativePosition { get; set; }
        [JsonPropertyAttribute]
        public string Text { get; set; }
        [JsonPropertyAttribute]
        public string FontName { get; set; }
        [JsonPropertyAttribute]
        public StringFormat Format { get; set; }
        [JsonPropertyAttribute]
        public float FontSize { get; set; }

        public RectangleF GetAbsolutePosition(float width, float height)
        {
            return new RectangleF(RelativePosition.Left * width,
                                 RelativePosition.Top * height,
                                 RelativePosition.Width * width,
                                 RelativePosition.Height * height);
        }

        [JsonConstructor]
        public Field()
        {
            Format = new StringFormat();
            FontSize = 12;
            FontName = "Courier New";
            RelativePosition = new RectangleF(0, 0, 1, 1);
            Format = new StringFormat();
            Format.Alignment = StringAlignment.Center;
            Format.LineAlignment = StringAlignment.Center;
        }
    }
}
