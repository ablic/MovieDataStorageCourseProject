using System;
using System.Data;
using System.Windows.Forms;
using MovieDataStorageCourseProject.UserControls;

namespace MovieDataStorageCourseProject
{
    public partial class MainForm : Form
    {
        private DataBase dataBase;

        public MainForm()
        {
            InitializeComponent();
            dataBase = new DataBase();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in dataBase.GetSelections().Rows)
            {
                SelectionsListBox.Items.Add(new SelectionInfo((int)row["id"], row["name"].ToString()));
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviewCardsPanel.Controls.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PreviewCardsPanel.Controls.Clear();

            int yearFromFilter = int.MinValue;
            int yearToFilter = int.MaxValue;

            try
            {
                if (YearFromFilterTextBox.Text != string.Empty)
                    yearFromFilter = int.Parse(YearFromFilterTextBox.Text);

                if (YearToFilterTextBox.Text != string.Empty)
                    yearToFilter = int.Parse(YearToFilterTextBox.Text);
            }
            catch (Exception)
            {
                ResetFilters();
                MessageBox.Show("Укажите корректные значения фильтров");
            }

            try
            {
                DataTable filmsTable = dataBase.GetFilmsByFilter(NameFilterTextBox.Text, yearFromFilter, yearToFilter);
                FillPreviewCardsPanel(filmsTable);
            }
            catch (Exception exeption)
            {
                MessageBox.Show("Ошибка получения данных (" + exeption.Message + ")");
            }
        }

        private void ResetFiltersButton_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void ResetFilters()
        {
            foreach (Control control in SearchTabPage.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }

        private void CreateSelectionButton_Click(object sender, EventArgs e)
        {
            SelectionNameChangeForm selectionNameChangeForm = new SelectionNameChangeForm();
            DialogResult dialogResult = selectionNameChangeForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string name = selectionNameChangeForm.EnteredName;

                try
                {
                    int id = dataBase.CreateSelection(name);
                    SelectionsListBox.Items.Add(new SelectionInfo(id, name));
                }
                catch (Exception exeption)
                {
                    MessageBox.Show($"Ошибка создания подборки ({exeption.Message})");
                }
            }
        }

        private void SelectionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectionsListBox.SelectedItem != null)
            {
                DeleteSelectionButton.Enabled = true;
                int selectionId = ((SelectionInfo)SelectionsListBox.SelectedItem).Id;
                FillPreviewCardsPanel(dataBase.GetSelectionFilms(selectionId));
            }
            else
            {
                DeleteSelectionButton.Enabled = false;
                PreviewCardsPanel.Controls.Clear();
            }
        }

        private void DeleteSelectionButton_Click(object sender, EventArgs e)
        {
            dataBase.DeleteSelection((SelectionInfo)SelectionsListBox.SelectedItem);
            SelectionsListBox.Items.RemoveAt(SelectionsListBox.SelectedIndex);
        }

        private void FillPreviewCardsPanel(DataTable filmsTable)
        {
            PreviewCardsPanel.Controls.Clear();

            if (filmsTable.Rows.Count > 0)
            {
                foreach (DataRow row in filmsTable.Rows)
                {
                    int id = (int)row["id"];
                    string name = row["name"].ToString();
                    int yearOfIssue = (int)row["year_of_issue"];
                    new PreviewCard(id, name, yearOfIssue).Parent = PreviewCardsPanel;
                }
            }
            else
            {
                Label emptyInfoLabel = new Label();
                emptyInfoLabel.AutoSize = true;
                emptyInfoLabel.Text = "Ничего не найдено :(";
                emptyInfoLabel.Parent = PreviewCardsPanel;
            }
        }
    }
}
