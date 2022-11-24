using System;
using System.Windows.Forms;

namespace MovieDataStorageCourseProject
{
    public partial class SelectionNameChangeForm : Form
    {
        public string EnteredName { get; private set; }

        public SelectionNameChangeForm(string initialName = "")
        {
            InitializeComponent();
            nameTextBox.Text = initialName;
        }

        private void ConfirmNameButton_Click(object sender, EventArgs e)
        {
            EnteredName = nameTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
