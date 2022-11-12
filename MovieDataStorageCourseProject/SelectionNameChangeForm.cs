using System;
using System.Windows.Forms;

namespace MovieDataStorageCourseProject
{
    public partial class SelectionNameChangeForm : Form
    {
        public string EnteredName { get; private set; }

        public SelectionNameChangeForm()
        {
            InitializeComponent();
        }

        private void ConfirmNameButton_Click(object sender, EventArgs e)
        {
            EnteredName = NameTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
