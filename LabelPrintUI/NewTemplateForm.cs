using System;
using System.Windows.Forms;
using LabelEngine2.Presenters;

namespace LabelPrintUI
{
    public partial class NewTemplateForm : Form, INewTemplateView
    {
        public NewTemplateForm()
        {
            InitializeComponent();
        }

        public string TemplateName { get => templateNameTB.Text; set => templateNameTB.Text = value; } //Имя шаблона
        public int TemplateWidth
        {
            get
            {
                int result = 0;
                int.TryParse(templateWidthTB.Text, out result);
                return result;
            }
            set
            {
                templateWidthTB.Text = value.ToString();
            }
        } //Ширина шаблона

        public int TemplateHeight
        {
            get
            {
                int result = 0;
                int.TryParse(templateHeightTB.Text, out result);
                return result;
            }
            set
            {
                templateHeightTB.Text = value.ToString();
            }
        } //Высота шаблона

        public NewTemplatePresenter Presenter { set; private get; }

        public new void Show()
        {
            this.ShowDialog(); //Показываем себя как модальное окно
        }


        private void createTemplateBtn_Click(object sender, EventArgs e)
        {
            if ((TemplateHeight == 0) || (TemplateWidth == 0) || (templateNameTB.Text == ""))
            {
                MessageBox.Show("Введите корректные значения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Presenter.AddTemplate(); //Создаем шаблон
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {            
            Presenter.Cancel(); //Отмена создания шаблона
        }
    }
}
