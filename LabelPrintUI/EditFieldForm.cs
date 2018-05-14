using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabelEngine2.Presenters;

namespace LabelPrintUI
{
    public partial class EditFieldForm : Form, IEditFieldView
    {
        private bool editingMode;

        public string Data { get => textTB.Text; set => textTB.Text = value; }
        public EditFieldPresenter Presenter { set; private get; }
        public string EditingTemplateName { set; private get; }
        public string EditingFieldName { set; private get; }
        public string FieldName { get => fieldNameTB.Text; set => fieldNameTB.Text = value; }
        public Font FieldFont { get; set; } = new Font("Courier New", 12);

        public EditFieldForm()
        {
            InitializeComponent();
        }

        public void Show(bool editingMode = false)
        {
            this.editingMode = editingMode;
            fontInfoTB.Text = FieldFont.Name + ' ' + FieldFont.Size.ToString();
            this.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Presenter.Cancel();
        }

        private void saveFieldBtn_Click(object sender, EventArgs e)
        {
            if ((fieldNameTB.Text == "") || (textTB.Text == "") || (FieldFont == null))
            {
                MessageBox.Show("Заполните поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!editingMode)
                Presenter.AddField(EditingTemplateName);
            else
                Presenter.EditField(EditingTemplateName, EditingFieldName);
        }

        private void changeFontBtn_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FieldFont = dialog.Font;
                    fontInfoTB.Text = FieldFont.Name + ' ' + FieldFont.Size.ToString();
                }
            }
        }
    }
}
