using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LabelEngine2.Presenters;
using LabelEngine2.Models;

namespace LabelPrintUI
{
    public partial class SettingsForm : Form, ISettingsView
    {
        public SettingsPresenter Presenter { set; private get; }
        public List<string> PrinterList { get => (List<string>)printerListCB.DataSource; set => printerListCB.DataSource = value; }
        public string TemplatesFolderPath { get => templatesPathTB.Text; set => templatesPathTB.Text = value; }
        public Image Preview { get => labelPreviewPB.Image; set => labelPreviewPB.Image = (Bitmap)value; }
        public List<string> TemplateList { get => (List<string>)templateListLB.DataSource; set => templateListLB.DataSource = value; }
        public List<string> SelectedTemplateFieldList { get => (List<string>)fieldsListCB.DataSource; set => fieldsListCB.DataSource = value; }
        public float FieldWidth { get => (float)Convert.ToDouble(fieldWidthTB.Text) / 100; set => fieldWidthTB.Text = Convert.ToString(100 * value); }
        public float FieldHeight { get => (float)Convert.ToDouble(fieldHeightTB.Text) / 100; set => fieldHeightTB.Text = Convert.ToString(100 * value); }

        public SettingsForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            this.ShowDialog();
        }

        private void addTemplateBtn_Click(object sender, EventArgs e)
        {
            var newTemplatePresenter = new NewTemplatePresenter(new NewTemplateForm(), Presenter.Model);
            newTemplatePresenter.Run();
            Presenter.UpdateTemplates();
            if (templateListLB.SelectedIndex < 0)
                return;
            Presenter.UpdateDesigner(templateListLB.SelectedItem.ToString());
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                Presenter.LoadSettings();
                string lastPrinterName = Presenter.GetPrinterName();
                if (printerListCB.Items.Contains(lastPrinterName))
                {
                    printerListCB.SelectedIndex = printerListCB.Items.IndexOf(lastPrinterName);
                }

                Presenter.UpdateTemplates();
                if (templateListLB.SelectedIndex < 0)
                    return;
                Presenter.UpdateFields(templateListLB.SelectedItem.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Произошла ошибка при открытии параметров", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteTemplateBtn_Click(object sender, EventArgs e)
        {
            if (templateListLB.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран шаблон!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Вы действительно хотите удалить шаблон?",
                                    "Подтверждение удаления",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                Presenter.DeleteTemplate(templateListLB.SelectedItem.ToString());
                Presenter.UpdateTemplates();
            }
        }

        private void templateListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templateListLB.SelectedIndex < 0)
                return;
            Presenter.UpdateDesigner(templateListLB.SelectedItem.ToString());
            Presenter.UpdateFields(templateListLB.SelectedItem.ToString());
        }

        private void AddTextFieldBtn_Click(object sender, EventArgs e)
        {
            if (templateListLB.SelectedIndex < 0)
                return;
            var editFieldPresenter = new EditFieldPresenter(new EditFieldForm(), Presenter.Model);
            editFieldPresenter.Run(templateListLB.SelectedItem.ToString());
            Presenter.UpdateFields(templateListLB.SelectedItem.ToString());
        }

        private void fieldsListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.UpdateFieldSettings(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString());
        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.MoveField(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), MovementDirection.Down);
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.MoveField(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), MovementDirection.Up);
        }

        private void printTemplateBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (printerListCB.SelectedIndex < 0))
                return;
            Presenter.PrintTemplate(templateListLB.SelectedItem.ToString(), printerListCB.SelectedItem.ToString());
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (printerListCB.SelectedIndex < 0)
                    return;
                Presenter.ChangePrinter(printerListCB.SelectedItem.ToString());
                Presenter.SaveSettings(printerListCB.SelectedItem.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Произошла ошибка при закрытии параметров", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.MoveField(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), MovementDirection.Left);
            string templateName = templateListLB.SelectedItem.ToString();
            Presenter.UpdateDesigner(templateName);

        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.MoveField(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), MovementDirection.Right);
            string templateName = templateListLB.SelectedItem.ToString();
            Presenter.UpdateDesigner(templateName);
        }


        private void editFieldDataBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            string templateName = templateListLB.SelectedItem.ToString();
            var editFieldPresenter = new EditFieldPresenter(new EditFieldForm(), Presenter.Model);
            editFieldPresenter.Run(templateName, fieldsListCB.SelectedItem.ToString());
            Presenter.UpdateFields(templateName);
            Presenter.UpdateDesigner(templateName);
        }

        private void deleteFieldBtn_Click(object sender, EventArgs e)
        {

            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
            {
                MessageBox.Show("Убедитесь, что шаблон и поле правильно выбраны!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Вы действительно хотите удалить поле?",
                                     "Подтверждение удаления",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                string templateName = templateListLB.SelectedItem.ToString();
                Presenter.DeleteField(templateName, fieldsListCB.SelectedItem.ToString());
                Presenter.UpdateFields(templateName);
                Presenter.UpdateDesigner(templateName);
            }

        }

        private void fieldWidthIncBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.ChangeFieldSize(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), SizeChanges.IncreaseFieldWidth);
            string templateName = templateListLB.SelectedItem.ToString();
            Presenter.UpdateDesigner(templateName);
        }

        private void fieldWidthDecBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.ChangeFieldSize(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), SizeChanges.DecreaseFieldWidth);
            string templateName = templateListLB.SelectedItem.ToString();
            Presenter.UpdateDesigner(templateName);
        }

        private void fieldHeightIncBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.ChangeFieldSize(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), SizeChanges.IncreaseFieldHeight);
            string templateName = templateListLB.SelectedItem.ToString();
            Presenter.UpdateDesigner(templateName);
        }

        private void fieldHeightDecBtn_Click(object sender, EventArgs e)
        {
            if ((templateListLB.SelectedIndex < 0) || (fieldsListCB.SelectedIndex < 0))
                return;
            Presenter.ChangeFieldSize(templateListLB.SelectedItem.ToString(), fieldsListCB.SelectedItem.ToString(), SizeChanges.DecreaseFieldHeight);
            string templateName = templateListLB.SelectedItem.ToString();
            Presenter.UpdateDesigner(templateName);
        }
    }
}
