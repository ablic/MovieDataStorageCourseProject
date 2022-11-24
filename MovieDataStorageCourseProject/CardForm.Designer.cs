
namespace MovieDataStorageCourseProject
{
    partial class CardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LinksListBox = new System.Windows.Forms.ListBox();
            this.LinksTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MajorTitleLabel = new System.Windows.Forms.Label();
            this.MinorTitleLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.InitialImage")));
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(300, 450);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // LinksListBox
            // 
            this.LinksListBox.FormattingEnabled = true;
            this.LinksListBox.ItemHeight = 16;
            this.LinksListBox.Location = new System.Drawing.Point(605, 106);
            this.LinksListBox.Name = "LinksListBox";
            this.LinksListBox.Size = new System.Drawing.Size(183, 324);
            this.LinksListBox.TabIndex = 9;
            // 
            // LinksTitleLabel
            // 
            this.LinksTitleLabel.AutoSize = true;
            this.LinksTitleLabel.Location = new System.Drawing.Point(605, 70);
            this.LinksTitleLabel.Name = "LinksTitleLabel";
            this.LinksTitleLabel.Size = new System.Drawing.Size(36, 17);
            this.LinksTitleLabel.TabIndex = 10;
            this.LinksTitleLabel.Text = "links";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(306, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 368);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // MajorTitleLabel
            // 
            this.MajorTitleLabel.AutoSize = true;
            this.MajorTitleLabel.Location = new System.Drawing.Point(306, 9);
            this.MajorTitleLabel.Name = "MajorTitleLabel";
            this.MajorTitleLabel.Size = new System.Drawing.Size(98, 17);
            this.MajorTitleLabel.TabIndex = 12;
            this.MajorTitleLabel.Text = "MAJOR TITLE";
            // 
            // MinorTitleLabel
            // 
            this.MinorTitleLabel.AutoSize = true;
            this.MinorTitleLabel.Location = new System.Drawing.Point(306, 26);
            this.MinorTitleLabel.Name = "MinorTitleLabel";
            this.MinorTitleLabel.Size = new System.Drawing.Size(69, 17);
            this.MinorTitleLabel.TabIndex = 13;
            this.MinorTitleLabel.Text = "minor title";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(605, 9);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(64, 17);
            this.RatingLabel.TabIndex = 14;
            this.RatingLabel.Text = "rating 99";
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.MinorTitleLabel);
            this.Controls.Add(this.MajorTitleLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LinksTitleLabel);
            this.Controls.Add(this.LinksListBox);
            this.Controls.Add(this.PictureBox);
            this.Name = "CardForm";
            this.Text = "FilmInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ListBox LinksListBox;
        private System.Windows.Forms.Label LinksTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MajorTitleLabel;
        private System.Windows.Forms.Label MinorTitleLabel;
        private System.Windows.Forms.Label RatingLabel;
    }
}