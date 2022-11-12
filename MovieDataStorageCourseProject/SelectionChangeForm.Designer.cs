
namespace MovieDataStorageCourseProject
{
    partial class SelectionChangeForm
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
            this.SelectionsListBox = new System.Windows.Forms.ListBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectionsListBox
            // 
            this.SelectionsListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectionsListBox.FormattingEnabled = true;
            this.SelectionsListBox.ItemHeight = 16;
            this.SelectionsListBox.Location = new System.Drawing.Point(0, 0);
            this.SelectionsListBox.Name = "SelectionsListBox";
            this.SelectionsListBox.Size = new System.Drawing.Size(381, 340);
            this.SelectionsListBox.TabIndex = 0;
            this.SelectionsListBox.SelectedIndexChanged += new System.EventHandler(this.SelectionsListBox_SelectedIndexChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Location = new System.Drawing.Point(252, 358);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(117, 46);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "ОК";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SelectionChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 416);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SelectionsListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionChangeForm";
            this.Text = "Выберите подборку";
            this.Load += new System.EventHandler(this.SelectionChangeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SelectionsListBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}