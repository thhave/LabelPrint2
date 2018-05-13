using System;
using System.Collections.Generic;
using System.Data;
using SpreadsheetLight;


namespace LabelEngine2.Models
{
    [System.ComponentModel.DesignerCategory("Code")]
    class ExcelDataProvider : DataTable, IDataProvider
    {
        public List<string> TableHeader { get; private set; } //Заголовки столбцов

        public List<Dictionary<string, string>> Data { get; set; }

        public DataTable Table { get => this; }
        
        public event System.Action TableChanged;

        public ExcelDataProvider()
        {
            this.TableChanged += new Action(OnTableChanged);
        }

        public void OnTableChanged()
        {
            DataView dv = new DataView(this);
            dv.RowFilter = this.DefaultView.RowFilter;

            Data = new List<Dictionary<string, string>>();
            //Добавление строк в DataTable
            for (int rowIndex = 0; rowIndex <= dv.Count - 1; rowIndex++)
            {
                //Добавляем ячейки в словарь с ключами именами столбцов
                Data.Add(new Dictionary<string, string>());

                for (int columnIndex = 0; columnIndex <= this.Columns.Count - 1; columnIndex++)
                {
                    Data[rowIndex].Add(Columns[columnIndex].ColumnName, (string)dv[rowIndex][columnIndex]);
                }          
            }
            
        }

        public void Load(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                throw new System.IO.FileNotFoundException();
            }

            SLDocument document;

            try
            {
                document = new SLDocument(filePath); //Открываем Excel документ
            }
            catch
            {
                throw new System.Exception("Невозможно открыть документ");
            }

            SLWorksheetStatistics stats = document.GetWorksheetStatistics(); //Статистика документа

            int startColumnIndex = stats.StartColumnIndex;//Индекс первого столбца
            int headerRowIndex = stats.StartRowIndex; //Индекс строки заголовков
            int startRowIndex = headerRowIndex + 1;  //Индекс первой строки данных

            TableHeader = new List<string>();
            //Получаем заголовки:
            for (int i = startColumnIndex; i <= stats.EndColumnIndex; ++i)
            {
                TableHeader.Add(document.GetCellValueAsString(headerRowIndex, i));
            }

            this.Columns.Clear();
            foreach (string h in TableHeader)
            {
                this.Columns.Add(new DataColumn(h)); //Заполняем DataTable заголовками столбцов
            }

            //Data = new List<Dictionary<string, string>>();
            //Добавление строк в DataTable
            for (int rowIndex = startRowIndex; rowIndex <= stats.EndRowIndex; rowIndex++)
            {
                //Добавляем ячейки в словарь с ключами именами столбцов
                //Data.Add(new Dictionary<string, string>());

                string[] newRow = new string[stats.NumberOfColumns]; //Массив ячеек строки
                for (int columnIndex = startColumnIndex; columnIndex <= stats.EndColumnIndex; columnIndex++)
                {
                    newRow[columnIndex - startColumnIndex] = document.GetCellValueAsString(rowIndex, columnIndex);
                    //Data[rowIndex - startRowIndex].Add(Columns[columnIndex - startColumnIndex].ColumnName, (string)newRow[columnIndex - startColumnIndex]);
                }
                this.Rows.Add(newRow); 
            }
            this.TableChanged();
        }

    }
}
