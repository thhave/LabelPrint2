namespace LabelPrintUI
{
    partial class NewTemplateForm
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
            this.templateNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.templateWidthTB = new System.Windows.Forms.TextBox();
            this.templateHeightTB = new System.Windows.Forms.TextBox();
            this.createTemplateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя шаблона";
            // 
            // templateNameTB
            // 
            this.templateNameTB.Location = new System.Drawing.Point(109, 14);
            this.templateNameTB.Name = "templateNameTB";
            this.templateNameTB.Size = new System.Drawing.Size(228, 20);
            this.templateNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Высота";
            // 
            // templateWidthTB
            // 
            this.templateWidthTB.Location = new System.Drawing.Point(109, 47);
            this.templateWidthTB.MaxLength = 4;
            this.templateWidthTB.Name = "templateWidthTB";
            this.templateWidthTB.Size = new System.Drawing.Size(79, 20);
            this.templateWidthTB.TabIndex = 4;
            this.templateWidthTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // templateHeightTB
            // 
            this.templateHeightTB.Location = new System.Drawing.Point(109, 79);
            this.templateHeightTB.MaxLength = 4;
            this.templateHeightTB.Name = "templateHeightTB";
            this.templateHeightTB.Size = new System.Drawing.Size(79, 20);
            this.templateHeightTB.TabIndex = 5;
            this.templateHeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // createTemplateBtn
            // 
            this.createTemplateBtn.Location = new System.Drawing.Point(15, 143);
            this.createTemplateBtn.Name = "createTemplateBtn";
            this.createTemplateBtn.Size = new System.Drawing.Size(75, 23);
            this.createTemplateBtn.TabIndex = 6;
            this.createTemplateBtn.Text = "Создать";
            this.createTemplateBtn.UseVisualStyleBackColor = true;
            this.createTemplateBtn.Click += new System.EventHandler(this.createTemplateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(262, 143);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // NewTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 178);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createTemplateBtn);
            this.Controls.Add(this.templateHeightTB);
            this.Controls.Add(this.templateWidthTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.templateNameTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTemplateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание нового шаблона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox templateNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox templateWidthTB;
        private System.Windows.Forms.TextBox templateHeightTB;
        private System.Windows.Forms.Button createTemplateBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}