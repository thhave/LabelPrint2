using System;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using LabelEngine2.Presenters;

namespace LabelPrintUI
{
    public partial class mainForm : Form, IMainView
    {
        private BindingSource binding;

        public mainForm()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null,
              gridView,
              new object[] { true }); //Убираем лаги DataGridView (использование двойной буферизации)
            binding = new BindingSource();
            gridView.DataSource = binding;
        }
        public DataTable Data { get => (this.binding.DataSource as DataTable); set => this.binding.DataSource = value; } //Данные из gridView
        public string SearchQuery { get => this.binding.Filter; set => this.binding.Filter = value; }
        public MainPresenter Presenter { private get; set; } //Презентер данной формы
        public Image Preview { get => labelPreviewPB.Image; set => labelPreviewPB.Image = (Bitmap)value; } //Превью этикетки
        public List<string> TemplateList { get => (List<string>)templatesListBox.DataSource; set => templatesListBox.DataSource = value; } //Список шаблонов на основной форме
        public List<string> ColumnList { get; set; } //Список названий столбцов таблицы DGV для поиска

        private void openMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = Presenter.FILES_FILTER, //Фильтр файлов по расширению
                FilterIndex = 1
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Presenter.LoadDataTable(dialog.FileName); //Загружаем данные в gridView
                Presenter.FillColumnList(); //Заполнить список заголовков для поиска (searchColumnCB)
            }
        }

        public new void Show()
        {
            Application.Run(this); //Запуск формы как основной
        }

        private void showSettingsMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(); //Форма параметров
            var settingsPresenter = new SettingsPresenter(settingsForm, Presenter.Model);
            settingsPresenter.Run(); //Открыть форму параметров
            Presenter.UpdateTemplateList();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Presenter.LoadTemplates(); //Загрузить шаблоны
            Presenter.UpdateTemplateList(); //Обновить список шаблонов
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.CloseView(); //Закрыть форму
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Presenter.ActionsBeforeClose(); //Выполнить какие-то действия перед закрытием формы (действия определяются презентером)
        }

        private void gridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((templatesListBox.SelectedIndex >= 0) && (e.RowIndex < gridView.RowCount - 1))
                Presenter.ChangeData(templatesListBox.SelectedItem.ToString(), e.RowIndex);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (templatesListBox.SelectedIndex >= 0)
                Presenter.PrintLabel(templatesListBox.SelectedItem.ToString());
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTB.Text.Trim() != "")
                Presenter.Search(searchTB.Text);
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            if ((templatesListBox.Items.Count > 0) && (gridView.SelectedCells.Count > 0))
                Presenter.ChangeData(templatesListBox.SelectedItem.ToString(), gridView.SelectedCells[0].RowIndex);
        }

        private void clearSearchTextBtn_Click(object sender, EventArgs e)
        {
            Presenter.ClearSearchText();
            searchTB.Clear();
        }
    }
}