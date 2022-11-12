
namespace MovieDataStorageCourseProject
{
    partial class SelectionNameChangeForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmNameButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(13, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(463, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // ConfirmNameButton
            // 
            this.ConfirmNameButton.Location = new System.Drawing.Point(355, 75);
            this.ConfirmNameButton.Name = "ConfirmNameButton";
            this.ConfirmNameButton.Size = new System.Drawing.Size(121, 34);
            this.ConfirmNameButton.TabIndex = 1;
            this.ConfirmNameButton.Text = "Подтвердить";
            this.ConfirmNameButton.UseVisualStyleBackColor = true;
            this.ConfirmNameButton.Click += new System.EventHandler(this.ConfirmNameButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(228, 75);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(121, 34);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectionNameChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 121);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmNameButton);
            this.Controls.Add(this.NameTextBox);
            this.Name = "SelectionNameChangeForm";
            this.Text = "Выберите имя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ConfirmNameButton;
        private System.Windows.Forms.Button CancelButton;
    }
}