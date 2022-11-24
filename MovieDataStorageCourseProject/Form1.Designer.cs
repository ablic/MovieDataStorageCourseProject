
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
            this.searchButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filmFiltersPanel = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.countriesFilterTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.yearToFilterNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.yearFromFilterNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.durationToFilterNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.durationFromFilterNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.genresFilterTextBox = new System.Windows.Forms.TextBox();
            this.filmNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearFilmFiltersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchPersonsRadioButton = new System.Windows.Forms.RadioButton();
            this.searchFilmsRadioButton = new System.Windows.Forms.RadioButton();
            this.searchAllRadioButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectionsPanel = new System.Windows.Forms.Panel();
            this.deleteSelectionButton = new System.Windows.Forms.Button();
            this.renameSelectionButton = new System.Windows.Forms.Button();
            this.createSelectionButton = new System.Windows.Forms.Button();
            this.selectionsListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectionSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.globalSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.searchResultFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.filmFiltersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearToFilterNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearFromFilterNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationToFilterNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationFromFilterNumUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.selectionsPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchButton.Location = new System.Drawing.Point(326, 621);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(564, 40);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(896, 621);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filmFiltersPanel);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 673);
            this.panel2.TabIndex = 10;
            // 
            // filmFiltersPanel
            // 
            this.filmFiltersPanel.Controls.Add(this.button10);
            this.filmFiltersPanel.Controls.Add(this.button11);
            this.filmFiltersPanel.Controls.Add(this.countriesFilterTextBox);
            this.filmFiltersPanel.Controls.Add(this.label9);
            this.filmFiltersPanel.Controls.Add(this.yearToFilterNumUpDown);
            this.filmFiltersPanel.Controls.Add(this.label6);
            this.filmFiltersPanel.Controls.Add(this.yearFromFilterNumUpDown);
            this.filmFiltersPanel.Controls.Add(this.label7);
            this.filmFiltersPanel.Controls.Add(this.label8);
            this.filmFiltersPanel.Controls.Add(this.durationToFilterNumUpDown);
            this.filmFiltersPanel.Controls.Add(this.label5);
            this.filmFiltersPanel.Controls.Add(this.durationFromFilterNumUpDown);
            this.filmFiltersPanel.Controls.Add(this.label4);
            this.filmFiltersPanel.Controls.Add(this.label2);
            this.filmFiltersPanel.Controls.Add(this.button9);
            this.filmFiltersPanel.Controls.Add(this.button8);
            this.filmFiltersPanel.Controls.Add(this.genresFilterTextBox);
            this.filmFiltersPanel.Controls.Add(this.filmNameFilterTextBox);
            this.filmFiltersPanel.Controls.Add(this.label3);
            this.filmFiltersPanel.Controls.Add(this.label1);
            this.filmFiltersPanel.Controls.Add(this.clearFilmFiltersButton);
            this.filmFiltersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmFiltersPanel.Location = new System.Drawing.Point(0, 126);
            this.filmFiltersPanel.Name = "filmFiltersPanel";
            this.filmFiltersPanel.Size = new System.Drawing.Size(320, 547);
            this.filmFiltersPanel.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(212, 363);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 30);
            this.button10.TabIndex = 38;
            this.button10.Text = "Очистить";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(11, 363);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(195, 30);
            this.button11.TabIndex = 37;
            this.button11.Text = "Добавить";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // countriesFilterTextBox
            // 
            this.countriesFilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countriesFilterTextBox.Location = new System.Drawing.Point(11, 330);
            this.countriesFilterTextBox.Name = "countriesFilterTextBox";
            this.countriesFilterTextBox.ReadOnly = true;
            this.countriesFilterTextBox.Size = new System.Drawing.Size(295, 27);
            this.countriesFilterTextBox.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Страны производства";
            // 
            // yearToFilterNumUpDown
            // 
            this.yearToFilterNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearToFilterNumUpDown.Location = new System.Drawing.Point(196, 263);
            this.yearToFilterNumUpDown.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.yearToFilterNumUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearToFilterNumUpDown.Name = "yearToFilterNumUpDown";
            this.yearToFilterNumUpDown.Size = new System.Drawing.Size(110, 27);
            this.yearToFilterNumUpDown.TabIndex = 34;
            this.yearToFilterNumUpDown.Value = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(163, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "до";
            // 
            // yearFromFilterNumUpDown
            // 
            this.yearFromFilterNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearFromFilterNumUpDown.Location = new System.Drawing.Point(47, 263);
            this.yearFromFilterNumUpDown.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.yearFromFilterNumUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearFromFilterNumUpDown.Name = "yearFromFilterNumUpDown";
            this.yearFromFilterNumUpDown.Size = new System.Drawing.Size(110, 27);
            this.yearFromFilterNumUpDown.TabIndex = 32;
            this.yearFromFilterNumUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "от";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Год выхода";
            // 
            // durationToFilterNumUpDown
            // 
            this.durationToFilterNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationToFilterNumUpDown.Location = new System.Drawing.Point(196, 192);
            this.durationToFilterNumUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.durationToFilterNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationToFilterNumUpDown.Name = "durationToFilterNumUpDown";
            this.durationToFilterNumUpDown.Size = new System.Drawing.Size(110, 27);
            this.durationToFilterNumUpDown.TabIndex = 29;
            this.durationToFilterNumUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(163, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "до";
            // 
            // durationFromFilterNumUpDown
            // 
            this.durationFromFilterNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationFromFilterNumUpDown.Location = new System.Drawing.Point(47, 192);
            this.durationFromFilterNumUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.durationFromFilterNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationFromFilterNumUpDown.Name = "durationFromFilterNumUpDown";
            this.durationFromFilterNumUpDown.Size = new System.Drawing.Size(110, 27);
            this.durationFromFilterNumUpDown.TabIndex = 27;
            this.durationFromFilterNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Продолжительность (мин)";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(212, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 30);
            this.button9.TabIndex = 23;
            this.button9.Text = "Очистить";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(11, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(195, 30);
            this.button8.TabIndex = 22;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // genresFilterTextBox
            // 
            this.genresFilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresFilterTextBox.Location = new System.Drawing.Point(11, 91);
            this.genresFilterTextBox.Name = "genresFilterTextBox";
            this.genresFilterTextBox.ReadOnly = true;
            this.genresFilterTextBox.Size = new System.Drawing.Size(295, 27);
            this.genresFilterTextBox.TabIndex = 21;
            // 
            // filmNameFilterTextBox
            // 
            this.filmNameFilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmNameFilterTextBox.Location = new System.Drawing.Point(12, 32);
            this.filmNameFilterTextBox.Name = "filmNameFilterTextBox";
            this.filmNameFilterTextBox.Size = new System.Drawing.Size(295, 27);
            this.filmNameFilterTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Жанры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // clearFilmFiltersButton
            // 
            this.clearFilmFiltersButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearFilmFiltersButton.Location = new System.Drawing.Point(57, 495);
            this.clearFilmFiltersButton.Name = "clearFilmFiltersButton";
            this.clearFilmFiltersButton.Size = new System.Drawing.Size(209, 40);
            this.clearFilmFiltersButton.TabIndex = 16;
            this.clearFilmFiltersButton.Text = "Очистить фильтры";
            this.clearFilmFiltersButton.UseVisualStyleBackColor = true;
            this.clearFilmFiltersButton.Click += new System.EventHandler(this.clearFilmFiltersButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchPersonsRadioButton);
            this.groupBox1.Controls.Add(this.searchFilmsRadioButton);
            this.groupBox1.Controls.Add(this.searchAllRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что искать?";
            // 
            // searchPersonsRadioButton
            // 
            this.searchPersonsRadioButton.AutoSize = true;
            this.searchPersonsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPersonsRadioButton.Location = new System.Drawing.Point(9, 89);
            this.searchPersonsRadioButton.Name = "searchPersonsRadioButton";
            this.searchPersonsRadioButton.Size = new System.Drawing.Size(77, 24);
            this.searchPersonsRadioButton.TabIndex = 2;
            this.searchPersonsRadioButton.Text = "Люди";
            this.searchPersonsRadioButton.UseVisualStyleBackColor = true;
            this.searchPersonsRadioButton.CheckedChanged += new System.EventHandler(this.searchRadioButton_CheckedChanged);
            // 
            // searchFilmsRadioButton
            // 
            this.searchFilmsRadioButton.AutoSize = true;
            this.searchFilmsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFilmsRadioButton.Location = new System.Drawing.Point(9, 59);
            this.searchFilmsRadioButton.Name = "searchFilmsRadioButton";
            this.searchFilmsRadioButton.Size = new System.Drawing.Size(191, 24);
            this.searchFilmsRadioButton.TabIndex = 1;
            this.searchFilmsRadioButton.Text = "Фильмы и сериалы";
            this.searchFilmsRadioButton.UseVisualStyleBackColor = true;
            this.searchFilmsRadioButton.CheckedChanged += new System.EventHandler(this.searchRadioButton_CheckedChanged);
            // 
            // searchAllRadioButton
            // 
            this.searchAllRadioButton.AutoSize = true;
            this.searchAllRadioButton.Checked = true;
            this.searchAllRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchAllRadioButton.Location = new System.Drawing.Point(9, 29);
            this.searchAllRadioButton.Name = "searchAllRadioButton";
            this.searchAllRadioButton.Size = new System.Drawing.Size(245, 24);
            this.searchAllRadioButton.TabIndex = 0;
            this.searchAllRadioButton.TabStop = true;
            this.searchAllRadioButton.Text = "Фильмы, сериалы и люди";
            this.searchAllRadioButton.UseVisualStyleBackColor = true;
            this.searchAllRadioButton.CheckedChanged += new System.EventHandler(this.searchRadioButton_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.selectionsPanel);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(942, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 673);
            this.panel3.TabIndex = 11;
            // 
            // selectionsPanel
            // 
            this.selectionsPanel.Controls.Add(this.deleteSelectionButton);
            this.selectionsPanel.Controls.Add(this.renameSelectionButton);
            this.selectionsPanel.Controls.Add(this.createSelectionButton);
            this.selectionsPanel.Controls.Add(this.selectionsListBox);
            this.selectionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectionsPanel.Location = new System.Drawing.Point(0, 129);
            this.selectionsPanel.Name = "selectionsPanel";
            this.selectionsPanel.Size = new System.Drawing.Size(320, 544);
            this.selectionsPanel.TabIndex = 2;
            // 
            // deleteSelectionButton
            // 
            this.deleteSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteSelectionButton.Location = new System.Drawing.Point(191, 492);
            this.deleteSelectionButton.Name = "deleteSelectionButton";
            this.deleteSelectionButton.Size = new System.Drawing.Size(40, 40);
            this.deleteSelectionButton.TabIndex = 15;
            this.deleteSelectionButton.Text = "Уд";
            this.deleteSelectionButton.UseVisualStyleBackColor = true;
            this.deleteSelectionButton.Click += new System.EventHandler(this.deleteSelectionButton_Click);
            // 
            // renameSelectionButton
            // 
            this.renameSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.renameSelectionButton.Location = new System.Drawing.Point(145, 492);
            this.renameSelectionButton.Name = "renameSelectionButton";
            this.renameSelectionButton.Size = new System.Drawing.Size(40, 40);
            this.renameSelectionButton.TabIndex = 14;
            this.renameSelectionButton.Text = "Из";
            this.renameSelectionButton.UseVisualStyleBackColor = true;
            this.renameSelectionButton.Click += new System.EventHandler(this.renameSelectionButton_Click);
            // 
            // createSelectionButton
            // 
            this.createSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createSelectionButton.Location = new System.Drawing.Point(99, 492);
            this.createSelectionButton.Name = "createSelectionButton";
            this.createSelectionButton.Size = new System.Drawing.Size(40, 40);
            this.createSelectionButton.TabIndex = 13;
            this.createSelectionButton.Text = "До";
            this.createSelectionButton.UseVisualStyleBackColor = true;
            this.createSelectionButton.Click += new System.EventHandler(this.createSelectionButton_Click);
            // 
            // selectionsListBox
            // 
            this.selectionsListBox.FormattingEnabled = true;
            this.selectionsListBox.ItemHeight = 16;
            this.selectionsListBox.Location = new System.Drawing.Point(3, 3);
            this.selectionsListBox.Name = "selectionsListBox";
            this.selectionsListBox.Size = new System.Drawing.Size(314, 484);
            this.selectionsListBox.TabIndex = 0;
            this.selectionsListBox.SelectedIndexChanged += new System.EventHandler(this.selectionsListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.selectionSearchRadioButton);
            this.groupBox2.Controls.Add(this.globalSearchRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Где искать?";
            // 
            // selectionSearchRadioButton
            // 
            this.selectionSearchRadioButton.AutoSize = true;
            this.selectionSearchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectionSearchRadioButton.Location = new System.Drawing.Point(6, 59);
            this.selectionSearchRadioButton.Name = "selectionSearchRadioButton";
            this.selectionSearchRadioButton.Size = new System.Drawing.Size(114, 24);
            this.selectionSearchRadioButton.TabIndex = 4;
            this.selectionSearchRadioButton.Text = "Подборки";
            this.selectionSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // globalSearchRadioButton
            // 
            this.globalSearchRadioButton.AutoSize = true;
            this.globalSearchRadioButton.Checked = true;
            this.globalSearchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalSearchRadioButton.Location = new System.Drawing.Point(6, 29);
            this.globalSearchRadioButton.Name = "globalSearchRadioButton";
            this.globalSearchRadioButton.Size = new System.Drawing.Size(185, 24);
            this.globalSearchRadioButton.TabIndex = 3;
            this.globalSearchRadioButton.TabStop = true;
            this.globalSearchRadioButton.Text = "Глобальный поиск";
            this.globalSearchRadioButton.UseVisualStyleBackColor = true;
            this.globalSearchRadioButton.CheckedChanged += new System.EventHandler(this.globalSearchRadioButton_CheckedChanged);
            // 
            // searchResultFlowLayoutPanel
            // 
            this.searchResultFlowLayoutPanel.AutoScroll = true;
            this.searchResultFlowLayoutPanel.Location = new System.Drawing.Point(326, 12);
            this.searchResultFlowLayoutPanel.Name = "searchResultFlowLayoutPanel";
            this.searchResultFlowLayoutPanel.Size = new System.Drawing.Size(610, 603);
            this.searchResultFlowLayoutPanel.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.searchResultFlowLayoutPanel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchButton);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.filmFiltersPanel.ResumeLayout(false);
            this.filmFiltersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearToFilterNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearFromFilterNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationToFilterNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationFromFilterNumUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.selectionsPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchPersonsRadioButton;
        private System.Windows.Forms.RadioButton searchFilmsRadioButton;
        private System.Windows.Forms.RadioButton searchAllRadioButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel selectionsPanel;
        private System.Windows.Forms.ListBox selectionsListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton selectionSearchRadioButton;
        private System.Windows.Forms.RadioButton globalSearchRadioButton;
        private System.Windows.Forms.Panel filmFiltersPanel;
        private System.Windows.Forms.FlowLayoutPanel searchResultFlowLayoutPanel;
        private System.Windows.Forms.Button deleteSelectionButton;
        private System.Windows.Forms.Button renameSelectionButton;
        private System.Windows.Forms.Button createSelectionButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox countriesFilterTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown yearToFilterNumUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown yearFromFilterNumUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown durationToFilterNumUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown durationFromFilterNumUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox genresFilterTextBox;
        private System.Windows.Forms.TextBox filmNameFilterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearFilmFiltersButton;
    }
}

