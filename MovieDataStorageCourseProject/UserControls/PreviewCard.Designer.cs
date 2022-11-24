
namespace MovieDataStorageCourseProject.UserControls
{
    partial class PreviewCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel1 = new System.Windows.Forms.Label();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.AddToSelectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(4, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(93, 93);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.FilmSearchResultElement_Click);
            // 
            // TitleLabel1
            // 
            this.TitleLabel1.AutoSize = true;
            this.TitleLabel1.Location = new System.Drawing.Point(104, 4);
            this.TitleLabel1.Name = "TitleLabel1";
            this.TitleLabel1.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel1.TabIndex = 2;
            this.TitleLabel1.Text = "Имя";
            this.TitleLabel1.Click += new System.EventHandler(this.FilmSearchResultElement_Click);
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Location = new System.Drawing.Point(104, 21);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(40, 17);
            this.TitleLabel2.TabIndex = 3;
            this.TitleLabel2.Text = "2015";
            this.TitleLabel2.Click += new System.EventHandler(this.FilmSearchResultElement_Click);
            // 
            // AddToSelectionButton
            // 
            this.AddToSelectionButton.Location = new System.Drawing.Point(421, 4);
            this.AddToSelectionButton.Name = "AddToSelectionButton";
            this.AddToSelectionButton.Size = new System.Drawing.Size(109, 34);
            this.AddToSelectionButton.TabIndex = 4;
            this.AddToSelectionButton.Text = "Добавить в ...";
            this.AddToSelectionButton.UseVisualStyleBackColor = true;
            this.AddToSelectionButton.Click += new System.EventHandler(this.AddToSelectionButton_Click);
            // 
            // PreviewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.AddToSelectionButton);
            this.Controls.Add(this.TitleLabel2);
            this.Controls.Add(this.TitleLabel1);
            this.Controls.Add(this.PictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PreviewCard";
            this.Size = new System.Drawing.Size(580, 100);
            this.Click += new System.EventHandler(this.FilmSearchResultElement_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label TitleLabel1;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Button AddToSelectionButton;
    }
}
