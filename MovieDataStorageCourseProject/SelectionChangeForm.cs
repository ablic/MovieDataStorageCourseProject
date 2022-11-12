using System;
using System.Data;
using System.Windows.Forms;

namespace MovieDataStorageCourseProject
{
    public partial class SelectionChangeForm : Form
    {
        private DataBase dataBase;
        private int filmId;

        public SelectionChangeForm(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;
            dataBase = new DataBase();
        }

        private void SelectionChangeForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in dataBase.GetSelections().Rows)
            {
                int selectionId = (int)row["id"];

                if (!dataBase.SelectionContainsFilm(selectionId, filmId))
                {
                    SelectionsListBox.Items.Add(new SelectionInfo(selectionId, row["name"].ToString()));
                }
            }
        }

        private void SelectionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = SelectionsListBox.SelectedItem != null;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int selectionId = ((SelectionInfo)SelectionsListBox.SelectedItem).Id;
            dataBase.AddFilmToSelection(selectionId, filmId);
            Close();
        }
    }
}
