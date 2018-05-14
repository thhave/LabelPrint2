using System;
using System.ComponentModel;
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
        private ProgressBarForm progressBarForm;
        private bool askToSave = false;

        public mainForm()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null,
              gridView,
              new object[] { true }); //Убираем лаги DataGridView (использование двойной буферизации)
            binding = new BindingSource();
            binding.AllowNew = true;
            gridView.DataSource = binding;

            progressBarForm = new ProgressBarForm();
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
                binding.DataSource = null;

                BackgroundWorker bw = new BackgroundWorker();

                bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                bw.RunWorkerAsync();

                progressBarForm.ShowDialog();
                Presenter.BindDataTable();
                Presenter.FillColumnList(); //Заполнить список заголовков для поиска (searchColumnCB)
                void bw_DoWork(object s, System.ComponentModel.DoWorkEventArgs eventArgs)
                {
                    try
                    {
                        Presenter.LoadDataTable(dialog.FileName); //Загружаем данные в gridView
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Произошла ошибка при загрузке таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                void bw_RunWorkerCompleted(object s, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
                {
                    progressBarForm.Close();
                    Presenter.LastFileName = dialog.FileName;
                    askToSave = true;
                }

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
            try
            {
                Presenter.LoadTemplates(); //Загрузить шаблоны
                Presenter.UpdateTemplateList(); //Обновить список шаблонов
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Произошла ошибка при открытии формы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.CloseView(); //Закрыть форму
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (askToSave)
                {
                    var confirmResult = MessageBox.Show("Сохранить таблицу?",
                                       "Сохранение",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            clearSearchTextBtn_Click(sender, new EventArgs());
                            saveMenuItem_Click(sender, new EventArgs());
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message, "Произошла ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                Presenter.ActionsBeforeClose(); //Выполнить какие-то действия перед закрытием формы (действия определяются презентером)
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Произошла ошибка при закрытии формы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (templatesListBox.SelectedIndex >= 0)
                Presenter.ChangeData(templatesListBox.SelectedItem.ToString(), e.RowIndex);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((templatesListBox.SelectedIndex >= 0) && (gridView.SelectedCells.Count > 0))
                    Presenter.PrintLabel(templatesListBox.SelectedItem.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Произошла ошибка при печати", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTB.Text.Trim() != "")
            {
                Presenter.Search(searchTB.Text);
                if (gridView.SelectedCells.Count > 0)
                    this.gridView_RowEnter(sender,
                                           new DataGridViewCellEventArgs(gridView.SelectedCells[0].ColumnIndex, gridView.SelectedCells[0].RowIndex));
            }
            else
                clearSearchTextBtn_Click(sender, e);

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
            if (gridView.SelectedCells.Count > 0)
                this.gridView_RowEnter(sender,
                                       new DataGridViewCellEventArgs(gridView.SelectedCells[0].ColumnIndex, gridView.SelectedCells[0].RowIndex));
        }

        private void gridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            askToSave = true;
            Presenter.ChangeTable();
            this.gridView_SelectionChanged(sender, e);
        }

        private void gridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            askToSave = true;
            gridView.Update();
            gridView.Refresh();
            Presenter.ChangeTable();
            this.gridView_SelectionChanged(sender, e);
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Presenter.FILES_FILTER;
            saveFileDialog.ShowDialog();

            BackgroundWorker bw = new BackgroundWorker();

            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
            progressBarForm.ShowDialog();

            void bw_DoWork(object s, System.ComponentModel.DoWorkEventArgs eventArgs)
            {
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        Presenter.SaveDataTable(saveFileDialog.FileName);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Произошла ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            void bw_RunWorkerCompleted(object s1, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
            {
                progressBarForm.Close();
                Presenter.LastFileName = saveFileDialog.FileName;
                askToSave = false;
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (Presenter.LastFileName == string.Empty)
            {
                saveAsMenuItem_Click(sender, e);
                return;
            }

            BackgroundWorker bw = new BackgroundWorker();

            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
            progressBarForm.ShowDialog();

            void bw_DoWork(object s, System.ComponentModel.DoWorkEventArgs eventArgs)
            {
                try
                {
                    Presenter.SaveDataTable(Presenter.LastFileName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Произошла ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            void bw_RunWorkerCompleted(object s1, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
            {
                progressBarForm.Close();
                askToSave = false;
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                saveMenuItem_Click(sender, new EventArgs());
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                printBtn_Click(sender, new EventArgs());
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                searchBtn_Click(sender, new EventArgs());
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }

        private void createDocumentMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.CreateNewDocument();
            askToSave = true;
        }

        private void gridView_Sorted(object sender, EventArgs e)
        {
            Presenter.ChangeTable();
        }
    }
}