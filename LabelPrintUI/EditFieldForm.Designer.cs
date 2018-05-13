namespace LabelPrintUI
{
    partial class EditFieldForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontInfoTB = new System.Windows.Forms.TextBox();
            this.changeFontBtn = new System.Windows.Forms.Button();
            this.saveFieldBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст";
            // 
            // textTB
            // 
            this.textTB.Location = new System.Drawing.Point(64, 72);
            this.textTB.Name = "textTB";
            this.textTB.Size = new System.Drawing.Size(380, 20);
            this.textTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Шрифт";
            // 
            // fontInfoTB
            // 
            this.fontInfoTB.Location = new System.Drawing.Point(64, 40);
            this.fontInfoTB.Name = "fontInfoTB";
            this.fontInfoTB.ReadOnly = true;
            this.fontInfoTB.Size = new System.Drawing.Size(299, 20);
            this.fontInfoTB.TabIndex = 3;
            // 
            // changeFontBtn
            // 
            this.changeFontBtn.Location = new System.Drawing.Point(369, 37);
            this.changeFontBtn.Name = "changeFontBtn";
            this.changeFontBtn.Size = new System.Drawing.Size(75, 23);
            this.changeFontBtn.TabIndex = 4;
            this.changeFontBtn.Text = "Изменить";
            this.changeFontBtn.UseVisualStyleBackColor = true;
            this.changeFontBtn.Click += new System.EventHandler(this.changeFontBtn_Click);
            // 
            // saveFieldBtn
            // 
            this.saveFieldBtn.Location = new System.Drawing.Point(15, 109);
            this.saveFieldBtn.Name = "saveFieldBtn";
            this.saveFieldBtn.Size = new System.Drawing.Size(75, 23);
            this.saveFieldBtn.TabIndex = 5;
            this.saveFieldBtn.Text = "Сохранить";
            this.saveFieldBtn.UseVisualStyleBackColor = true;
            this.saveFieldBtn.Click += new System.EventHandler(this.saveFieldBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(369, 109);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // fieldNameTB
            // 
            this.fieldNameTB.Location = new System.Drawing.Point(64, 6);
            this.fieldNameTB.Name = "fieldNameTB";
            this.fieldNameTB.Size = new System.Drawing.Size(380, 20);
            this.fieldNameTB.TabIndex = 1;
            // 
            // EditFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 144);
            this.Controls.Add(this.fieldNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveFieldBtn);
            this.Controls.Add(this.changeFontBtn);
            this.Controls.Add(this.fontInfoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование текстового поля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fontInfoTB;
        private System.Windows.Forms.Button changeFontBtn;
        private System.Windows.Forms.Button saveFieldBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fieldNameTB;
    }
}