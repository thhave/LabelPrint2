namespace LabelPrintUI
{
    partial class mainForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftPanelSplitter2 = new System.Windows.Forms.Splitter();
            this.labelPreviewGB = new System.Windows.Forms.GroupBox();
            this.leftPanelSplitter1 = new System.Windows.Forms.Splitter();
            this.templatesGB = new System.Windows.Forms.GroupBox();
            this.templatesListBox = new System.Windows.Forms.ListBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.clearSearchTextBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.leftSplitter = new System.Windows.Forms.Splitter();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitterMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPreviewPB = new System.Windows.Forms.PictureBox();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel.SuspendLayout();
            this.labelPreviewGB.SuspendLayout();
            this.templatesGB.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelPreviewPB)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.leftPanel.Controls.Add(this.leftPanelSplitter2);
            this.leftPanel.Controls.Add(this.labelPreviewGB);
            this.leftPanel.Controls.Add(this.leftPanelSplitter1);
            this.leftPanel.Controls.Add(this.templatesGB);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 24);
            this.leftPanel.MinimumSize = new System.Drawing.Size(200, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 551);
            this.leftPanel.TabIndex = 0;
            // 
            // leftPanelSplitter2
            // 
            this.leftPanelSplitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanelSplitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelSplitter2.Location = new System.Drawing.Point(0, 357);
            this.leftPanelSplitter2.Name = "leftPanelSplitter2";
            this.leftPanelSplitter2.Size = new System.Drawing.Size(200, 2);
            this.leftPanelSplitter2.TabIndex = 7;
            this.leftPanelSplitter2.TabStop = false;
            // 
            // labelPreviewGB
            // 
            this.labelPreviewGB.Controls.Add(this.labelPreviewPB);
            this.labelPreviewGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPreviewGB.Location = new System.Drawing.Point(0, 182);
            this.labelPreviewGB.Name = "labelPreviewGB";
            this.labelPreviewGB.Size = new System.Drawing.Size(200, 175);
            this.labelPreviewGB.TabIndex = 6;
            this.labelPreviewGB.TabStop = false;
            this.labelPreviewGB.Text = "Предпросмотр этикетки";
            // 
            // leftPanelSplitter1
            // 
            this.leftPanelSplitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanelSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelSplitter1.Location = new System.Drawing.Point(0, 180);
            this.leftPanelSplitter1.Name = "leftPanelSplitter1";
            this.leftPanelSplitter1.Size = new System.Drawing.Size(200, 2);
            this.leftPanelSplitter1.TabIndex = 5;
            this.leftPanelSplitter1.TabStop = false;
            // 
            // templatesGB
            // 
            this.templatesGB.Controls.Add(this.templatesListBox);
            this.templatesGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.templatesGB.Location = new System.Drawing.Point(0, 0);
            this.templatesGB.Name = "templatesGB";
            this.templatesGB.Size = new System.Drawing.Size(200, 180);
            this.templatesGB.TabIndex = 0;
            this.templatesGB.TabStop = false;
            this.templatesGB.Text = "Шаблоны этикеток";
            // 
            // templatesListBox
            // 
            this.templatesListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.templatesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.templatesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templatesListBox.FormattingEnabled = true;
            this.templatesListBox.Location = new System.Drawing.Point(3, 16);
            this.templatesListBox.Name = "templatesListBox";
            this.templatesListBox.Size = new System.Drawing.Size(194, 161);
            this.templatesListBox.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.clearSearchTextBtn);
            this.topPanel.Controls.Add(this.printBtn);
            this.topPanel.Controls.Add(this.searchBtn);
            this.topPanel.Controls.Add(this.searchTB);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(200, 24);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(763, 49);
            this.topPanel.TabIndex = 1;
            // 
            // clearSearchTextBtn
            // 
            this.clearSearchTextBtn.Location = new System.Drawing.Point(299, 14);
            this.clearSearchTextBtn.Name = "clearSearchTextBtn";
            this.clearSearchTextBtn.Size = new System.Drawing.Size(67, 26);
            this.clearSearchTextBtn.TabIndex = 4;
            this.clearSearchTextBtn.Text = "Очистить";
            this.clearSearchTextBtn.UseVisualStyleBackColor = true;
            this.clearSearchTextBtn.Click += new System.EventHandler(this.clearSearchTextBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.Location = new System.Drawing.Point(641, 14);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(110, 26);
            this.printBtn.TabIndex = 2;
            this.printBtn.Text = "Печать";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(226, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(67, 26);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Найти";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.Location = new System.Drawing.Point(6, 16);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(210, 21);
            this.searchTB.TabIndex = 0;
            this.searchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyDown);
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.gridView);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(200, 73);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(763, 502);
            this.centerPanel.TabIndex = 2;
            // 
            // gridView
            // 
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(763, 502);
            this.gridView.TabIndex = 0;
            this.gridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellEndEdit);
            this.gridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_RowEnter);
            this.gridView.SelectionChanged += new System.EventHandler(this.gridView_SelectionChanged);
            this.gridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridView_UserAddedRow);
            // 
            // leftSplitter
            // 
            this.leftSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftSplitter.Location = new System.Drawing.Point(200, 73);
            this.leftSplitter.Name = "leftSplitter";
            this.leftSplitter.Size = new System.Drawing.Size(2, 502);
            this.leftSplitter.TabIndex = 3;
            this.leftSplitter.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.toolsMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(963, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.splitterMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMenuItem.Text = "Открыть";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // splitterMenuItem
            // 
            this.splitterMenuItem.Name = "splitterMenuItem";
            this.splitterMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Enabled = false;
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editMenuItem.Text = "Правка";
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSettingsMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(59, 20);
            this.toolsMenuItem.Text = "Сервис";
            // 
            // showSettingsMenuItem
            // 
            this.showSettingsMenuItem.Name = "showSettingsMenuItem";
            this.showSettingsMenuItem.Size = new System.Drawing.Size(138, 22);
            this.showSettingsMenuItem.Text = "Параметры";
            this.showSettingsMenuItem.Click += new System.EventHandler(this.showSettingsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelpMenuItem,
            this.showAboutMenuItem});
            this.helpMenuItem.Enabled = false;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpMenuItem.Text = "Справка";
            // 
            // showHelpMenuItem
            // 
            this.showHelpMenuItem.Name = "showHelpMenuItem";
            this.showHelpMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showHelpMenuItem.Text = "Помощь";
            // 
            // showAboutMenuItem
            // 
            this.showAboutMenuItem.Name = "showAboutMenuItem";
            this.showAboutMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showAboutMenuItem.Text = "О программе";
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsMenuItem.Text = "Сохранить как...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // labelPreviewPB
            // 
            this.labelPreviewPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPreviewPB.Location = new System.Drawing.Point(3, 16);
            this.labelPreviewPB.Name = "labelPreviewPB";
            this.labelPreviewPB.Size = new System.Drawing.Size(194, 156);
            this.labelPreviewPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelPreviewPB.TabIndex = 0;
            this.labelPreviewPB.TabStop = false;
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 575);
            this.Controls.Add(this.leftSplitter);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(816, 614);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать этикеток";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.leftPanel.ResumeLayout(false);
            this.labelPreviewGB.ResumeLayout(false);
            this.templatesGB.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelPreviewPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Splitter leftSplitter;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.GroupBox templatesGB;
        private System.Windows.Forms.ListBox templatesListBox;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripSeparator splitterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAboutMenuItem;
        private System.Windows.Forms.Splitter leftPanelSplitter1;
        private System.Windows.Forms.GroupBox labelPreviewGB;
        private System.Windows.Forms.Splitter leftPanelSplitter2;
        private System.Windows.Forms.PictureBox labelPreviewPB;
        private System.Windows.Forms.Button clearSearchTextBtn;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
    }
}

