
namespace MovieDataStorageCourseProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.ResetFiltersButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.YearToFilterTextBox = new System.Windows.Forms.TextBox();
            this.NameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YearFromFilterTextBox = new System.Windows.Forms.TextBox();
            this.SelectionsTabPage = new System.Windows.Forms.TabPage();
            this.DeleteSelectionButton = new System.Windows.Forms.Button();
            this.CreateSelectionButton = new System.Windows.Forms.Button();
            this.SelectionsListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PreviewCardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TabControl.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            this.SelectionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SearchTabPage);
            this.TabControl.Controls.Add(this.SelectionsTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(420, 673);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.ResetFiltersButton);
            this.SearchTabPage.Controls.Add(this.SearchButton);
            this.SearchTabPage.Controls.Add(this.YearToFilterTextBox);
            this.SearchTabPage.Controls.Add(this.NameFilterTextBox);
            this.SearchTabPage.Controls.Add(this.label2);
            this.SearchTabPage.Controls.Add(this.label3);
            this.SearchTabPage.Controls.Add(this.label1);
            this.SearchTabPage.Controls.Add(this.YearFromFilterTextBox);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 25);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(412, 644);
            this.SearchTabPage.TabIndex = 0;
            this.SearchTabPage.Text = "Поиск";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // ResetFiltersButton
            // 
            this.ResetFiltersButton.Location = new System.Drawing.Point(160, 596);
            this.ResetFiltersButton.Name = "ResetFiltersButton";
            this.ResetFiltersButton.Size = new System.Drawing.Size(120, 42);
            this.ResetFiltersButton.TabIndex = 8;
            this.ResetFiltersButton.Text = "Сбросить";
            this.ResetFiltersButton.UseVisualStyleBackColor = true;
            this.ResetFiltersButton.Click += new System.EventHandler(this.ResetFiltersButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(286, 596);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(120, 42);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // YearToFilterTextBox
            // 
            this.YearToFilterTextBox.Location = new System.Drawing.Point(235, 53);
            this.YearToFilterTextBox.Name = "YearToFilterTextBox";
            this.YearToFilterTextBox.Size = new System.Drawing.Size(74, 22);
            this.YearToFilterTextBox.TabIndex = 6;
            // 
            // NameFilterTextBox
            // 
            this.NameFilterTextBox.Location = new System.Drawing.Point(83, 6);
            this.NameFilterTextBox.Name = "NameFilterTextBox";
            this.NameFilterTextBox.Size = new System.Drawing.Size(323, 22);
            this.NameFilterTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Год выпуска от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // YearFromFilterTextBox
            // 
            this.YearFromFilterTextBox.Location = new System.Drawing.Point(124, 52);
            this.YearFromFilterTextBox.Name = "YearFromFilterTextBox";
            this.YearFromFilterTextBox.Size = new System.Drawing.Size(74, 22);
            this.YearFromFilterTextBox.TabIndex = 4;
            // 
            // SelectionsTabPage
            // 
            this.SelectionsTabPage.Controls.Add(this.DeleteSelectionButton);
            this.SelectionsTabPage.Controls.Add(this.CreateSelectionButton);
            this.SelectionsTabPage.Controls.Add(this.SelectionsListBox);
            this.SelectionsTabPage.Location = new System.Drawing.Point(4, 25);
            this.SelectionsTabPage.Name = "SelectionsTabPage";
            this.SelectionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectionsTabPage.Size = new System.Drawing.Size(412, 644);
            this.SelectionsTabPage.TabIndex = 1;
            this.SelectionsTabPage.Text = "Подборки";
            this.SelectionsTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectionButton
            // 
            this.DeleteSelectionButton.Enabled = false;
            this.DeleteSelectionButton.Location = new System.Drawing.Point(160, 596);
            this.DeleteSelectionButton.Name = "DeleteSelectionButton";
            this.DeleteSelectionButton.Size = new System.Drawing.Size(120, 42);
            this.DeleteSelectionButton.TabIndex = 9;
            this.DeleteSelectionButton.Text = "Удалить";
            this.DeleteSelectionButton.UseVisualStyleBackColor = true;
            this.DeleteSelectionButton.Click += new System.EventHandler(this.DeleteSelectionButton_Click);
            // 
            // CreateSelectionButton
            // 
            this.CreateSelectionButton.Location = new System.Drawing.Point(286, 596);
            this.CreateSelectionButton.Name = "CreateSelectionButton";
            this.CreateSelectionButton.Size = new System.Drawing.Size(120, 42);
            this.CreateSelectionButton.TabIndex = 8;
            this.CreateSelectionButton.Text = "Создать";
            this.CreateSelectionButton.UseVisualStyleBackColor = true;
            this.CreateSelectionButton.Click += new System.EventHandler(this.CreateSelectionButton_Click);
            // 
            // SelectionsListBox
            // 
            this.SelectionsListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectionsListBox.FormattingEnabled = true;
            this.SelectionsListBox.ItemHeight = 16;
            this.SelectionsListBox.Location = new System.Drawing.Point(3, 3);
            this.SelectionsListBox.Name = "SelectionsListBox";
            this.SelectionsListBox.Size = new System.Drawing.Size(406, 564);
            this.SelectionsListBox.TabIndex = 0;
            this.SelectionsListBox.SelectedIndexChanged += new System.EventHandler(this.SelectionsListBox_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PreviewCardsPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 673);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 1;
            // 
            // PreviewCardsPanel
            // 
            this.PreviewCardsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewCardsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PreviewCardsPanel.Location = new System.Drawing.Point(0, 0);
            this.PreviewCardsPanel.Name = "PreviewCardsPanel";
            this.PreviewCardsPanel.Size = new System.Drawing.Size(838, 673);
            this.PreviewCardsPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.SearchTabPage.ResumeLayout(false);
            this.SearchTabPage.PerformLayout();
            this.SelectionsTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.TextBox NameFilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage SelectionsTabPage;
        private System.Windows.Forms.TextBox YearToFilterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YearFromFilterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel PreviewCardsPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ResetFiltersButton;
        private System.Windows.Forms.ListBox SelectionsListBox;
        private System.Windows.Forms.Button DeleteSelectionButton;
        private System.Windows.Forms.Button CreateSelectionButton;
    }
}

