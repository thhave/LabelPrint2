using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LabelEngine2
{
    [Serializable]
    public class AppConfig 
    {
        [JsonPropertyAttribute]
        public string TemplatePath { get; set; } = "./templates/";
        [JsonPropertyAttribute]
        public string PrinterName { get; set; } 
        [JsonPropertyAttribute]
        public string LastSelectedTemplate { get; set; }

        public List<string> GetAllPrinters()
        {
            List<string> printers = new List<string>();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                printers.Add(printer);
            }
            return printers;
        }
    }

}
