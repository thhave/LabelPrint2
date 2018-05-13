using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace LabelEngine2.Models
{
    [Serializable]
    class Template : ITemplate
    {
        [JsonPropertyAttribute]
        public Dictionary<string, IField> Fields { get; set; }
        [JsonPropertyAttribute]
        public SizeF Size { get; set; }

        [JsonConstructor]
        public Template(SizeF size)
        {
            Fields = new Dictionary<string, IField>();
            Size = size;
        }
    }
}
