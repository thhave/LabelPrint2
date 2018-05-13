using LabelEngine2.Models;
using System.Collections.Generic;
using System.Drawing;

namespace LabelEngine2.Presenters
{
    public class SettingsPresenter
    {
        private ISettingsView _view;
        private IModel _model;

        public IModel Model { get => _model; }

        public SettingsPresenter(ISettingsView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.Presenter = this;
        }

        public void Run()
        {
            _view.Show();
        }

        //View controlling methods
        public void UpdateTemplates()
        {
            List<string> templates = new List<string>();
            foreach (var entry in _model.Repository.Templates)
            {
                templates.Add(entry.Key);
            }
            _view.TemplateList = templates;
        }
        public void LoadSettings()
        {
            _view.PrinterList = _model.Config.GetAllPrinters();
        }

        public void DeleteTemplate(string templateName)
        {
            _model.Repository.Templates.Remove(templateName);
        }

        public void UpdateDesigner(string templateName)
        {
            LabelRenderer renderer = new LabelRenderer(_model.Repository.Templates[templateName], Color.Ivory);
            renderer.Render();
            _view.Preview = renderer.Image;
        }

        public void UpdateFields(string templateName)
        {
            List<string> fields = new List<string>();
            foreach (var entry in _model.Repository.Templates[templateName].Fields)
            {
                fields.Add(entry.Key);
            }
            _view.SelectedTemplateFieldList = fields;
            UpdateDesigner(templateName);
        }

        public void UpdateFieldSettings(string templateName, string fieldName)
        {
            _view.FieldWidth = _model.Repository.Templates[templateName].Fields[fieldName].RelativePosition.Width;
            _view.FieldHeight = _model.Repository.Templates[templateName].Fields[fieldName].RelativePosition.Height;
        }

        public void MoveField(string templateName, string fieldName, MovementDirection direction, float step = 0.01f)
        {
            RectangleF newPosition = _model.Repository.Templates[templateName].Fields[fieldName].RelativePosition;
           
            switch (direction)
            {
                case MovementDirection.Up:
                    {
                        if ((newPosition.Y - step) >= 0)
                            newPosition.Y -= step;
                        break;
                    }
                case MovementDirection.Down:
                    {
                        if ((newPosition.Y + step) <= 1)
                            newPosition.Y += step;
                        break;
                    }
                case MovementDirection.Left:
                    {
                        if ((newPosition.X - step) >= 0)
                            newPosition.X -= step;
                        break;
                    }
                case MovementDirection.Right:
                    {
                        if ((newPosition.X + step) >= 0)
                            newPosition.X += step;
                        break;
                    }
            }
            _model.Repository.Templates[templateName].Fields[fieldName].RelativePosition = newPosition;
            UpdateDesigner(templateName);
        }

        public void PrintTemplate(string templateName, string printerName)
        {

            _model.Printer = new Printer(printerName);
            LabelRenderer renderer = new LabelRenderer(_model.Repository.Templates[templateName]);
            renderer.Render();
            _model.Printer.Print(renderer.Image);

        }
        public void SaveSettings() { }

        public void DeleteField(string templateName, string fieldName)
        {
            _model.Repository.Templates[templateName].Fields.Remove(fieldName);
        }

        public void ChangeFieldSize(string templateName, string fieldName, SizeChanges change, float step = 0.01f)
        {
            RectangleF oldPosition = _model.Repository.Templates[templateName].Fields[fieldName].RelativePosition;
            RectangleF newPosition = oldPosition;
            switch (change)
            {
                case SizeChanges.IncreaseFieldWidth:
                    {
                        if ((oldPosition.Width + step) <= 1)
                            newPosition.Width += step; break;
                    }
                case SizeChanges.DecreaseFieldWidth:
                    {
                        if ((oldPosition.Width - step) >= 0)
                            newPosition.Width -= step; break;
                    }
                case SizeChanges.IncreaseFieldHeight:
                    {
                        if ((oldPosition.Height + step) <= 1)
                            newPosition.Height += step; break;
                    }
                case SizeChanges.DecreaseFieldHeight:
                    {
                        if ((oldPosition.Height - step) >= 0)
                            newPosition.Height -= step; break;
                    }
            }
            _model.Repository.Templates[templateName].Fields[fieldName].RelativePosition = newPosition;

        }

        public void ChangePrinter(string printerName)
        {
            _model.Config.PrinterName = printerName;
            _model.Printer = new Printer(_model.Config.PrinterName);
        }
    }
}
