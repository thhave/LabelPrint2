using System;
using System.Collections.Generic;
using System.Drawing;
using LabelEngine2.Models;
using System.Text;


namespace LabelEngine2.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;
        private IModel _model;

        public string FILES_FILTER { get; private set; } = "xlsx файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
        public IModel Model { get => _model; }
        public string LastFileName { get; set; } = string.Empty;

        public MainPresenter(IMainView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.Presenter = this;
        }

        public void Run()
        {
            _view.Show();
        }

        //View Controlling Methods
        public void LoadDataTable(string fileName)
        {
             _model.DataProvider.Load(fileName);
        }

        public void BindDataTable()
        {
            _view.Data = _model.DataProvider.Table;
        }

        public void SaveDataTable(string fileName)
        {
            _model.DataProvider.Save(fileName);
        }

        public void FillColumnList()
        {
            List<string> columns = new List<string>();
            foreach (var column in _model.DataProvider.Table.Columns)
            {
                columns.Add(column.ToString());
            }
            _view.ColumnList = columns;
        }

        public void UpdateTemplateList()
        {
            List<string> templateNames = new List<string>();
            foreach (var entry in _model.Repository.Templates)
            {
                templateNames.Add(entry.Key);
            }
            _view.TemplateList = templateNames;
        }

        public void LoadTemplates()
        {
            _model.Repository.LoadFromFolder(_model.Config.TemplatePath);
        }

        public void CloseView()
        {
            _view.Close();
        }

        public void ActionsBeforeClose()
        {
            _model.Repository.SaveToFolder(_model.Config.TemplatePath);
            _model.SaveState();
        }

        public void ChangeData(string templateName, int rowIndex)
        {
            if ((_view.Data.Rows.Count - 1 != _model.DataProvider.Data.Count) || (_view.Data.Rows.Count - 1 != _model.DataProvider.Table.Rows.Count))
                ChangeTable();
            int maxRowIndex = _model.DataProvider.Data.Count - 1;
            if (maxRowIndex < rowIndex)
                return;
            foreach (var entry in _model.DataProvider.Data[rowIndex])
                if (_model.Repository.Templates[templateName].Fields.ContainsKey(entry.Key))
                    _model.Repository.Templates[templateName].Fields[entry.Key].Text = entry.Value;
            LabelRenderer renderer = new LabelRenderer(_model.Repository.Templates[templateName], Color.Ivory);
            renderer.Render();
            _view.Preview = renderer.Image;
        }

        public void PrintLabel(string templateName)
        {
            LabelRenderer renderer = new LabelRenderer(_model.Repository.Templates[templateName]);
            renderer.Render();
            _model.Printer.Print(renderer.Image);
        }

        public void Search(string text)
        {
            if ((_view.Data == null) || (_view.ColumnList == null))
                return;
            if ((_view.ColumnList.Count == 0) || (_view.Data.Rows.Count == 0))
                return;
            StringBuilder columnSearchQueries = new StringBuilder();
            foreach (var column in _view.ColumnList)
            {
                if (columnSearchQueries.ToString() == "")
                    columnSearchQueries.Append(string.Format("CONVERT([{0}], System.String) LIKE '{1}'", column, text.Trim()));
                else
                {
                    columnSearchQueries.Append(" OR ");
                    columnSearchQueries.Append(string.Format("CONVERT([{0}], System.String) LIKE '{1}'", column, text.Trim()));
                }
            }
            _view.SearchQuery = columnSearchQueries.ToString();
            _model.DataProvider.Table.DefaultView.RowFilter = columnSearchQueries.ToString();
            _model.DataProvider.OnTableChanged();
        }

        public void ClearSearchText()
        {
            _view.SearchQuery = "";
            _model.DataProvider.Table.DefaultView.RowFilter = "";
            _model.DataProvider.OnTableChanged();
        }

        public void ChangeTable()
        {
            _model.DataProvider.OnTableChanged();
        }

        
    }
}
