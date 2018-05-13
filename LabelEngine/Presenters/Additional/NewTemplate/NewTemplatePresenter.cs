using System;
using LabelEngine2.Models;
using System.Drawing;

namespace LabelEngine2.Presenters
{
    public class NewTemplatePresenter
    {
        private INewTemplateView _view;
        private IModel _model;

        public NewTemplatePresenter(INewTemplateView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.Presenter = this;
        }

        public void Run()
        {
            _view.Show();
        }

        public void AddTemplate()
        {
            var newTemplate = new Template(new SizeF(Convert.ToInt32(_view.TemplateWidth), Convert.ToInt32(_view.TemplateHeight)));
            _model.Repository.Templates.Add(_view.TemplateName, newTemplate);
            _view.Close();
        }

        public void Cancel()
        {
            _view.Close();
        }
    }
}
