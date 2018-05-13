using System;
using System.IO;

namespace LabelEngine2.Models
{
    public class Model : IModel
    {
        private const string CONFIG_PATH = "./config.json";

        public AppConfig Config { get => ConfigurationManager.AppConfig; }
        public ILabelRepository Repository { get; set; }
        public IDataProvider DataProvider { get; set; }
        public IPrinter Printer { get; set; }

        public Model()
        {
            if (File.Exists(CONFIG_PATH))
                ConfigurationManager.LoadFromFile(CONFIG_PATH);
            Repository = new LabelRepository();
            DataProvider = new ExcelDataProvider();
            Printer = new Printer(Config.PrinterName);
        }

        public void SaveState()
        {
            try
            {
                ConfigurationManager.SaveToFile(CONFIG_PATH);
            }
            catch
            {
                ConfigurationManager.SaveToFile(CONFIG_PATH + "_EMERGENCY");
            }
        }
    }
}
