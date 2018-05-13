using System.Drawing;
using LabelEngine2.Models;

namespace LabelEngine2.Presenters
{
    public class EditFieldPresenter
    {
        private IEditFieldView _view;
        private IModel _model;

        public EditFieldPresenter(IEditFieldView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.Presenter = this;
        }

        public void Run(string templateName)
        {
            _view.EditingTemplateName = templateName;
            _view.Show();   
        }

        public void Run(string templateName, string fieldName)
        {
            _view.EditingTemplateName = templateName;
            _view.EditingFieldName = fieldName;
            _view.FieldName = fieldName;
            _view.Data = _model.Repository.Templates[templateName].Fields[fieldName].Text;
            _view.FieldFont = new Font(_model.Repository.Templates[templateName].Fields[fieldName].FontName,
                                       _model.Repository.Templates[templateName].Fields[fieldName].FontSize);
            _view.Show(true);
        }

        public void Cancel()
        {
            _view.Close();
        }

        public void AddField(string templateName)
        {
            var newField = new Field();
            newField.FontName = _view.FieldFont.Name;
            newField.FontSize = _view.FieldFont.Size;
            newField.Text = _view.Data;
            _model.Repository.Templates[templateName].Fields.Add(_view.FieldName, newField);
            _view.Close();
        }

        public void EditField(string templateName, string fieldName)
        {
            _model.Repository.Templates[templateName].Fields[fieldName].FontName = _view.FieldFont.Name;
            _model.Repository.Templates[templateName].Fields[fieldName].FontSize = _view.FieldFont.Size;
            _model.Repository.Templates[templateName].Fields[fieldName].Text = _view.Data;
            _view.Close();
        }
    }
}
