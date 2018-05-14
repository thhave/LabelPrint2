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

        public event Action TableChanged;

        public ExcelDataProvider()
        {
            this.TableChanged += new Action(OnTableChanged);
        }

        public void OnTableChanged()
        {
            DataView dv = this.DefaultView;//new DataView(this);
            //dv.RowFilter = this.DefaultView.RowFilter;

            Data = new List<Dictionary<string, string>>();
            //Добавление строк в DataTable
            for (int rowIndex = 0; rowIndex < dv.Count; rowIndex++)
            {
                //Добавляем ячейки в словарь с ключами именами столбцов
                Data.Add(new Dictionary<string, string>());

                for (int columnIndex = 0; columnIndex < this.Columns.Count; columnIndex++)
                {
                    try
                    {
                        if (dv[rowIndex][columnIndex] != System.DBNull.Value)
                            Data[rowIndex].Add(Columns[columnIndex].ColumnName, (string)dv[rowIndex][columnIndex]);
                        else
                            Data[rowIndex].Add(Columns[columnIndex].ColumnName, string.Empty);
                    }
                    catch (InvalidCastException)
                    {
                        Data[rowIndex].Add(Columns[columnIndex].ColumnName, string.Empty);
                    }
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

            this.Rows.Clear();
            //Добавление строк в DataTable
            for (int rowIndex = startRowIndex; rowIndex <= stats.EndRowIndex; rowIndex++)
            {
                //Добавляем ячейки в словарь с ключами именами столбцов

                string[] newRow = new string[stats.NumberOfColumns]; //Массив ячеек строки

                for (int columnIndex = startColumnIndex; columnIndex <= stats.EndColumnIndex; columnIndex++)
                {
                    newRow[columnIndex - startColumnIndex] = document.GetCellValueAsString(rowIndex, columnIndex);
                }

                this.Rows.Add(newRow);
            }
            this.TableChanged();
        }

        public void Save(string filePath)
        {
            DataTable tempTable = new DataTable();

            for (int i = 0; i < this.Columns.Count; i++)
            {
                tempTable.Columns.Add(this.Columns[i].ColumnName);
            }

            for (int i = 0; i < this.Rows.Count; i++)
            {
                DataRow row = tempTable.NewRow();
                for (int j = 0; j < this.Columns.Count; j++)
                {
                    row[j] = this.Rows[i][j].ToString();
                }
                tempTable.Rows.Add(row);
            }

            SLDocument sL = new SLDocument();
            int iStartRowIndex = 1;
            int iStartColumnIndex = 1;
            sL.ImportDataTable(iStartRowIndex, iStartColumnIndex, tempTable, true);

            SLStyle style = sL.CreateStyle();

            int iEndRowIndex = iStartRowIndex + tempTable.Rows.Count;
            int iEndColumnIndex = iStartColumnIndex + tempTable.Columns.Count - 1;
            sL.AutoFitColumn(iStartColumnIndex, iEndColumnIndex, 500);

            SLTable table = sL.CreateTable(iStartRowIndex, iStartColumnIndex, iEndRowIndex, iEndColumnIndex);
            table.SetTableStyle(SLTableStyleTypeValues.Medium17);
            sL.InsertTable(table);

            try
            {
                sL.SaveAs(filePath);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void CreateNew()
        {
            int startColumnIndex = 1;//Индекс первого столбца
            int headerRowIndex = 1; //Индекс строки заголовков
            int startRowIndex = headerRowIndex + 1;  //Индекс первой строки данных
            int endColumnIndex = 10;

            TableHeader = new List<string>();
            //Получаем заголовки:
            for (int i = startColumnIndex; i <= endColumnIndex; ++i)
            {
                TableHeader.Add(string.Format("Column {0}", i));
            }

            this.Columns.Clear();
            foreach (string h in TableHeader)
            {
                this.Columns.Add(new DataColumn(h)); //Заполняем DataTable заголовками столбцов
            }

            this.Rows.Clear();
            string[] newRow = new string[endColumnIndex - startColumnIndex];
            this.Rows.Add(newRow);
            this.TableChanged();
        }
    }
}
