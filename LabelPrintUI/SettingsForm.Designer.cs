namespace LabelPrintUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.templatesSettingsPage = new System.Windows.Forms.TabPage();
            this.fieldHeightDecBtn = new System.Windows.Forms.Button();
            this.fieldHeightIncBtn = new System.Windows.Forms.Button();
            this.fieldWidthDecBtn = new System.Windows.Forms.Button();
            this.fieldWidthIncBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fieldHeightTB = new System.Windows.Forms.TextBox();
            this.fieldWidthTB = new System.Windows.Forms.TextBox();
            this.printTemplateBtn = new System.Windows.Forms.Button();
            this.deleteFieldBtn = new System.Windows.Forms.Button();
            this.editFieldDataBtn = new System.Windows.Forms.Button();
            this.AddTextFieldBtn = new System.Windows.Forms.Button();
            this.fieldsListCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.moveRightBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.labelPreviewPB = new System.Windows.Forms.PictureBox();
            this.deleteTemplateBtn = new System.Windows.Forms.Button();
            this.addTemplateBtn = new System.Windows.Forms.Button();
            this.templateListLB = new System.Windows.Forms.ListBox();
            this.printerSettingsPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.printerListCB = new System.Windows.Forms.ComboBox();
            this.systemSettingsTabPage = new System.Windows.Forms.TabPage();
            this.browseTemplatePathBtn = new System.Windows.Forms.Button();
            this.templatesPathTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsTabControl.SuspendLayout();
            this.templatesSettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelPreviewPB)).BeginInit();
            this.printerSettingsPage.SuspendLayout();
            this.systemSettingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.templatesSettingsPage);
            this.settingsTabControl.Controls.Add(this.printerSettingsPage);
            this.settingsTabControl.Controls.Add(this.systemSettingsTabPage);
            this.settingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(800, 450);
            this.settingsTabControl.TabIndex = 0;
            // 
            // templatesSettingsPage
            // 
            this.templatesSettingsPage.Controls.Add(this.fieldHeightDecBtn);
            this.templatesSettingsPage.Controls.Add(this.fieldHeightIncBtn);
            this.templatesSettingsPage.Controls.Add(this.fieldWidthDecBtn);
            this.templatesSettingsPage.Controls.Add(this.fieldWidthIncBtn);
            this.templatesSettingsPage.Controls.Add(this.label5);
            this.templatesSettingsPage.Controls.Add(this.label4);
            this.templatesSettingsPage.Controls.Add(this.fieldHeightTB);
            this.templatesSettingsPage.Controls.Add(this.fieldWidthTB);
            this.templatesSettingsPage.Controls.Add(this.printTemplateBtn);
            this.templatesSettingsPage.Controls.Add(this.deleteFieldBtn);
            this.templatesSettingsPage.Controls.Add(this.editFieldDataBtn);
            this.templatesSettingsPage.Controls.Add(this.AddTextFieldBtn);
            this.templatesSettingsPage.Controls.Add(this.fieldsListCB);
            this.templatesSettingsPage.Controls.Add(this.label2);
            this.templatesSettingsPage.Controls.Add(this.moveRightBtn);
            this.templatesSettingsPage.Controls.Add(this.moveLeftBtn);
            this.templatesSettingsPage.Controls.Add(this.moveDownBtn);
            this.templatesSettingsPage.Controls.Add(this.moveUpBtn);
            this.templatesSettingsPage.Controls.Add(this.labelPreviewPB);
            this.templatesSettingsPage.Controls.Add(this.deleteTemplateBtn);
            this.templatesSettingsPage.Controls.Add(this.addTemplateBtn);
            this.templatesSettingsPage.Controls.Add(this.templateListLB);
            this.templatesSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.templatesSettingsPage.Name = "templatesSettingsPage";
            this.templatesSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.templatesSettingsPage.Size = new System.Drawing.Size(792, 424);
            this.templatesSettingsPage.TabIndex = 0;
            this.templatesSettingsPage.Text = "Шаблоны";
            this.templatesSettingsPage.UseVisualStyleBackColor = true;
            // 
            // fieldHeightDecBtn
            // 
            this.fieldHeightDecBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldHeightDecBtn.Location = new System.Drawing.Point(760, 257);
            this.fieldHeightDecBtn.Name = "fieldHeightDecBtn";
            this.fieldHeightDecBtn.Size = new System.Drawing.Size(24, 20);
            this.fieldHeightDecBtn.TabIndex = 28;
            this.fieldHeightDecBtn.Text = "-";
            this.fieldHeightDecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fieldHeightDecBtn.UseVisualStyleBackColor = true;
            this.fieldHeightDecBtn.Click += new System.EventHandler(this.fieldHeightDecBtn_Click);
            // 
            // fieldHeightIncBtn
            // 
            this.fieldHeightIncBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldHeightIncBtn.Location = new System.Drawing.Point(730, 257);
            this.fieldHeightIncBtn.Name = "fieldHeightIncBtn";
            this.fieldHeightIncBtn.Size = new System.Drawing.Size(24, 20);
            this.fieldHeightIncBtn.TabIndex = 27;
            this.fieldHeightIncBtn.Text = "+";
            this.fieldHeightIncBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fieldHeightIncBtn.UseVisualStyleBackColor = true;
            this.fieldHeightIncBtn.Click += new System.EventHandler(this.fieldHeightIncBtn_Click);
            // 
            // fieldWidthDecBtn
            // 
            this.fieldWidthDecBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldWidthDecBtn.Location = new System.Drawing.Point(760, 231);
            this.fieldWidthDecBtn.Name = "fieldWidthDecBtn";
            this.fieldWidthDecBtn.Size = new System.Drawing.Size(24, 20);
            this.fieldWidthDecBtn.TabIndex = 26;
            this.fieldWidthDecBtn.Text = "-";
            this.fieldWidthDecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fieldWidthDecBtn.UseVisualStyleBackColor = true;
            this.fieldWidthDecBtn.Click += new System.EventHandler(this.fieldWidthDecBtn_Click);
            // 
            // fieldWidthIncBtn
            // 
            this.fieldWidthIncBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldWidthIncBtn.Location = new System.Drawing.Point(730, 231);
            this.fieldWidthIncBtn.Name = "fieldWidthIncBtn";
            this.fieldWidthIncBtn.Size = new System.Drawing.Size(24, 20);
            this.fieldWidthIncBtn.TabIndex = 25;
            this.fieldWidthIncBtn.Text = "+";
            this.fieldWidthIncBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fieldWidthIncBtn.UseVisualStyleBackColor = true;
            this.fieldWidthIncBtn.Click += new System.EventHandler(this.fieldWidthIncBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Высота";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ширина";
            // 
            // fieldHeightTB
            // 
            this.fieldHeightTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldHeightTB.Location = new System.Drawing.Point(660, 258);
            this.fieldHeightTB.Name = "fieldHeightTB";
            this.fieldHeightTB.ReadOnly = true;
            this.fieldHeightTB.Size = new System.Drawing.Size(64, 20);
            this.fieldHeightTB.TabIndex = 22;
            this.fieldHeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fieldWidthTB
            // 
            this.fieldWidthTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldWidthTB.Location = new System.Drawing.Point(660, 231);
            this.fieldWidthTB.Name = "fieldWidthTB";
            this.fieldWidthTB.ReadOnly = true;
            this.fieldWidthTB.Size = new System.Drawing.Size(64, 20);
            this.fieldWidthTB.TabIndex = 21;
            this.fieldWidthTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // printTemplateBtn
            // 
            this.printTemplateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printTemplateBtn.Location = new System.Drawing.Point(448, 293);
            this.printTemplateBtn.Name = "printTemplateBtn";
            this.printTemplateBtn.Size = new System.Drawing.Size(151, 23);
            this.printTemplateBtn.TabIndex = 20;
            this.printTemplateBtn.Text = "Печать";
            this.printTemplateBtn.UseVisualStyleBackColor = true;
            this.printTemplateBtn.Click += new System.EventHandler(this.printTemplateBtn_Click);
            // 
            // deleteFieldBtn
            // 
            this.deleteFieldBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFieldBtn.Location = new System.Drawing.Point(708, 60);
            this.deleteFieldBtn.Name = "deleteFieldBtn";
            this.deleteFieldBtn.Size = new System.Drawing.Size(78, 23);
            this.deleteFieldBtn.TabIndex = 19;
            this.deleteFieldBtn.Text = "Удалить";
            this.deleteFieldBtn.UseVisualStyleBackColor = true;
            this.deleteFieldBtn.Click += new System.EventHandler(this.deleteFieldBtn_Click);
            // 
            // editFieldDataBtn
            // 
            this.editFieldDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editFieldDataBtn.Location = new System.Drawing.Point(607, 60);
            this.editFieldDataBtn.Name = "editFieldDataBtn";
            this.editFieldDataBtn.Size = new System.Drawing.Size(78, 23);
            this.editFieldDataBtn.TabIndex = 18;
            this.editFieldDataBtn.Text = "Изменить";
            this.editFieldDataBtn.UseVisualStyleBackColor = true;
            this.editFieldDataBtn.Click += new System.EventHandler(this.editFieldDataBtn_Click);
            // 
            // AddTextFieldBtn
            // 
            this.AddTextFieldBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTextFieldBtn.Location = new System.Drawing.Point(200, 293);
            this.AddTextFieldBtn.Name = "AddTextFieldBtn";
            this.AddTextFieldBtn.Size = new System.Drawing.Size(151, 23);
            this.AddTextFieldBtn.TabIndex = 13;
            this.AddTextFieldBtn.Text = "Добавить текстовое поле";
            this.AddTextFieldBtn.UseVisualStyleBackColor = true;
            this.AddTextFieldBtn.Click += new System.EventHandler(this.AddTextFieldBtn_Click);
            // 
            // fieldsListCB
            // 
            this.fieldsListCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldsListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldsListCB.FormattingEnabled = true;
            this.fieldsListCB.Location = new System.Drawing.Point(607, 33);
            this.fieldsListCB.Name = "fieldsListCB";
            this.fieldsListCB.Size = new System.Drawing.Size(179, 21);
            this.fieldsListCB.TabIndex = 12;
            this.fieldsListCB.SelectedIndexChanged += new System.EventHandler(this.fieldsListCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Редактируемое поле";
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveRightBtn.Location = new System.Drawing.Point(719, 148);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(24, 23);
            this.moveRightBtn.TabIndex = 8;
            this.moveRightBtn.Text = "→";
            this.moveRightBtn.UseVisualStyleBackColor = true;
            this.moveRightBtn.Click += new System.EventHandler(this.moveRightBtn_Click);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveLeftBtn.Location = new System.Drawing.Point(669, 148);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(24, 23);
            this.moveLeftBtn.TabIndex = 7;
            this.moveLeftBtn.Text = "←";
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.Click += new System.EventHandler(this.moveLeftBtn_Click);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownBtn.Location = new System.Drawing.Point(694, 177);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(24, 23);
            this.moveDownBtn.TabIndex = 5;
            this.moveDownBtn.Text = "↓";
            this.moveDownBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler(this.moveDownBtn_Click);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpBtn.Location = new System.Drawing.Point(694, 120);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(24, 23);
            this.moveUpBtn.TabIndex = 4;
            this.moveUpBtn.Text = "↑";
            this.moveUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler(this.moveUpBtn_Click);
            // 
            // labelPreviewPB
            // 
            this.labelPreviewPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreviewPB.BackColor = System.Drawing.Color.DarkGray;
            this.labelPreviewPB.BackgroundImage = global::LabelPrintUI.Properties.Resources.Transparent_Background;
            this.labelPreviewPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPreviewPB.Location = new System.Drawing.Point(200, 15);
            this.labelPreviewPB.Name = "labelPreviewPB";
            this.labelPreviewPB.Size = new System.Drawing.Size(399, 262);
            this.labelPreviewPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelPreviewPB.TabIndex = 3;
            this.labelPreviewPB.TabStop = false;
            // 
            // deleteTemplateBtn
            // 
            this.deleteTemplateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteTemplateBtn.Location = new System.Drawing.Point(119, 395);
            this.deleteTemplateBtn.Name = "deleteTemplateBtn";
            this.deleteTemplateBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteTemplateBtn.TabIndex = 2;
            this.deleteTemplateBtn.Text = "Удалить";
            this.deleteTemplateBtn.UseVisualStyleBackColor = true;
            this.deleteTemplateBtn.Click += new System.EventHandler(this.deleteTemplateBtn_Click);
            // 
            // addTemplateBtn
            // 
            this.addTemplateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addTemplateBtn.Location = new System.Drawing.Point(8, 395);
            this.addTemplateBtn.Name = "addTemplateBtn";
            this.addTemplateBtn.Size = new System.Drawing.Size(75, 23);
            this.addTemplateBtn.TabIndex = 1;
            this.addTemplateBtn.Text = "Добавить";
            this.addTemplateBtn.UseVisualStyleBackColor = true;
            this.addTemplateBtn.Click += new System.EventHandler(this.addTemplateBtn_Click);
            // 
            // templateListLB
            // 
            this.templateListLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.templateListLB.FormattingEnabled = true;
            this.templateListLB.Location = new System.Drawing.Point(8, 15);
            this.templateListLB.Name = "templateListLB";
            this.templateListLB.Size = new System.Drawing.Size(186, 368);
            this.templateListLB.TabIndex = 0;
            this.templateListLB.SelectedIndexChanged += new System.EventHandler(this.templateListLB_SelectedIndexChanged);
            // 
            // printerSettingsPage
            // 
            this.printerSettingsPage.Controls.Add(this.label1);
            this.printerSettingsPage.Controls.Add(this.printerListCB);
            this.printerSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.printerSettingsPage.Name = "printerSettingsPage";
            this.printerSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.printerSettingsPage.Size = new System.Drawing.Size(792, 424);
            this.printerSettingsPage.TabIndex = 1;
            this.printerSettingsPage.Text = "Настройки принтера";
            this.printerSettingsPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя принтера";
            // 
            // printerListCB
            // 
            this.printerListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerListCB.FormattingEnabled = true;
            this.printerListCB.Location = new System.Drawing.Point(93, 20);
            this.printerListCB.Name = "printerListCB";
            this.printerListCB.Size = new System.Drawing.Size(312, 21);
            this.printerListCB.TabIndex = 0;
            // 
            // systemSettingsTabPage
            // 
            this.systemSettingsTabPage.Controls.Add(this.browseTemplatePathBtn);
            this.systemSettingsTabPage.Controls.Add(this.templatesPathTB);
            this.systemSettingsTabPage.Controls.Add(this.label3);
            this.systemSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.systemSettingsTabPage.Name = "systemSettingsTabPage";
            this.systemSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.systemSettingsTabPage.Size = new System.Drawing.Size(792, 424);
            this.systemSettingsTabPage.TabIndex = 2;
            this.systemSettingsTabPage.Text = "Системные настройки";
            this.systemSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // browseTemplatePathBtn
            // 
            this.browseTemplatePathBtn.Enabled = false;
            this.browseTemplatePathBtn.Location = new System.Drawing.Point(569, 14);
            this.browseTemplatePathBtn.Name = "browseTemplatePathBtn";
            this.browseTemplatePathBtn.Size = new System.Drawing.Size(75, 23);
            this.browseTemplatePathBtn.TabIndex = 2;
            this.browseTemplatePathBtn.Text = "Обзор";
            this.browseTemplatePathBtn.UseVisualStyleBackColor = true;
            // 
            // templatesPathTB
            // 
            this.templatesPathTB.Enabled = false;
            this.templatesPathTB.Location = new System.Drawing.Point(184, 16);
            this.templatesPathTB.Name = "templatesPathTB";
            this.templatesPathTB.Size = new System.Drawing.Size(367, 20);
            this.templatesPathTB.TabIndex = 1;
            this.templatesPathTB.Text = "./templates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Путь расположения шаблонов";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settingsTabControl.ResumeLayout(false);
            this.templatesSettingsPage.ResumeLayout(false);
            this.templatesSettingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelPreviewPB)).EndInit();
            this.printerSettingsPage.ResumeLayout(false);
            this.printerSettingsPage.PerformLayout();
            this.systemSettingsTabPage.ResumeLayout(false);
            this.systemSettingsTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage templatesSettingsPage;
        private System.Windows.Forms.TabPage printerSettingsPage;
        private System.Windows.Forms.Button moveRightBtn;
        private System.Windows.Forms.Button moveLeftBtn;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.PictureBox labelPreviewPB;
        private System.Windows.Forms.Button deleteTemplateBtn;
        private System.Windows.Forms.Button addTemplateBtn;
        private System.Windows.Forms.ListBox templateListLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox printerListCB;
        private System.Windows.Forms.ComboBox fieldsListCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printTemplateBtn;
        private System.Windows.Forms.Button deleteFieldBtn;
        private System.Windows.Forms.Button editFieldDataBtn;
        private System.Windows.Forms.Button AddTextFieldBtn;
        private System.Windows.Forms.TabPage systemSettingsTabPage;
        private System.Windows.Forms.Button browseTemplatePathBtn;
        private System.Windows.Forms.TextBox templatesPathTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fieldHeightDecBtn;
        private System.Windows.Forms.Button fieldHeightIncBtn;
        private System.Windows.Forms.Button fieldWidthDecBtn;
        private System.Windows.Forms.Button fieldWidthIncBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fieldHeightTB;
        private System.Windows.Forms.TextBox fieldWidthTB;
    }
}