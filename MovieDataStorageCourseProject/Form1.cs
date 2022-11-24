using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MovieDataStorageCourseProject.UserControls;

namespace MovieDataStorageCourseProject
{
    public partial class MainForm : Form
    {
        private DataBase dataBase;

        private List<string> selectedGenres = new List<string>();
        private List<string> selectedCountries = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            dataBase = new DataBase();
        }

        #region Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            searchRadioButton_CheckedChanged(null, null);
            UpdateSelectionListButtons();

            foreach (DataRow row in dataBase.GetSelections().Rows)
            {
                int id = (int)row["id"];
                string name = row["name"].ToString();
                selectionsListBox.Items.Add(new SelectionInfo(id, name));
            }
        }

        private void searchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            filmFiltersPanel.Visible = searchFilmsRadioButton.Checked;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void clearFilmFiltersButton_Click(object sender, EventArgs e)
        {

        }

        private void globalSearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void selectionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectionsListBox.SelectedItem != null)
            {
                int selectionId = ((SelectionInfo)selectionsListBox.SelectedItem).Id;
                ShowSearchResult(dataBase.GetSelectionFilms(selectionId));
            }
            else
            {
                //searchResultFlowLayoutPanel.Controls.Clear();
            }

            UpdateSelectionListButtons();
        }

        private void createSelectionButton_Click(object sender, EventArgs e)
        {
            SelectionNameChangeForm selectionNameChangeForm = new SelectionNameChangeForm();
            DialogResult dialogResult = selectionNameChangeForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string name = selectionNameChangeForm.EnteredName;

                try
                {
                    int id = dataBase.CreateSelection(name);
                    selectionsListBox.Items.Add(new SelectionInfo(id, name));
                }
                catch (Exception exeption)
                {
                    MessageBox.Show($"Ошибка создания подборки ({exeption.Message})");
                }
            }
        }

        private void renameSelectionButton_Click(object sender, EventArgs e)
        {
            SelectionInfo selectedSelection = (SelectionInfo)selectionsListBox.SelectedItem;
            SelectionNameChangeForm selectionNameChangeForm = new SelectionNameChangeForm(selectedSelection.Name);
            DialogResult dialogResult = selectionNameChangeForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string name = selectionNameChangeForm.EnteredName;
                int id = selectedSelection.Id;

                if (name == selectedSelection.Name)
                {
                    return;
                }

                try
                {
                    dataBase.RenameSelection(selectedSelection.Id, name);
                    selectionsListBox.Items.RemoveAt(selectionsListBox.SelectedIndex);
                    selectionsListBox.Items.Add(new SelectionInfo(id, name));
                }
                catch (Exception exeption)
                {
                    MessageBox.Show($"Ошибка переименования подборки ({exeption.Message})");
                }
            }

            UpdateSelectionListButtons();
        }

        private void deleteSelectionButton_Click(object sender, EventArgs e)
        {
            dataBase.DeleteSelection((SelectionInfo)selectionsListBox.SelectedItem);
            selectionsListBox.Items.RemoveAt(selectionsListBox.SelectedIndex);
            UpdateSelectionListButtons();
        }

        #endregion

        private void Search()
        {
            if (searchAllRadioButton.Checked)
            {
                ShowSearchResult(dataBase.GetAllFilms());
            }
            else if (searchFilmsRadioButton.Checked)
            {
                string namePart = filmNameFilterTextBox.Text;
                int durationFrom = (int)durationFromFilterNumUpDown.Value;
                int durationTo = (int)durationToFilterNumUpDown.Value;
                int yearFrom = (int)yearFromFilterNumUpDown.Value;
                int yearTo = (int)yearToFilterNumUpDown.Value;

                ShowSearchResult(dataBase.GetFilmsByFilter(namePart, yearFrom, yearTo));
            }
            else if (searchPersonsRadioButton.Checked)
            {

            }
        }

        private void ShowSearchResult(DataTable table)
        {
            searchResultFlowLayoutPanel.Controls.Clear();

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    int id = (int)row["id"];
                    string name = row["name"].ToString();
                    int yearOfIssue = (int)row["year_of_issue"];
                    new PreviewCard(id, name, yearOfIssue).Parent = searchResultFlowLayoutPanel;
                }
            }
            else
            {
                Label emptyInfoLabel = new Label();
                emptyInfoLabel.AutoSize = true;
                emptyInfoLabel.Text = "Ничего не найдено :(";
                emptyInfoLabel.Parent = searchResultFlowLayoutPanel;
            }
        }

        private void UpdateSelectionListButtons()
        {
            if (selectionsListBox.SelectedItem == null)
            {
                renameSelectionButton.Enabled = false;
                deleteSelectionButton.Enabled = false;
            }
            else
            {
                renameSelectionButton.Enabled = true;
                deleteSelectionButton.Enabled = true;
            }
        }
    }
}
