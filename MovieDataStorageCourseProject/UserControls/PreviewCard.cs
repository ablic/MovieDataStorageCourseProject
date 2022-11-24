using System.Windows.Forms;

namespace MovieDataStorageCourseProject.UserControls
{
    public partial class PreviewCard : UserControl
    {
        private int id;
        private string name;
        private int yearOfIssue;

        public PreviewCard(int id, string name, int yearOfIssue)
        {
            InitializeComponent();

            this.id = id;
            this.name = name;
            this.yearOfIssue = yearOfIssue;

            TitleLabel1.Text = name;
            TitleLabel2.Text = yearOfIssue.ToString();
            PictureBox.Image = PictureBox.InitialImage; 
        }

        private void FilmSearchResultElement_Click(object sender, System.EventArgs e)
        {
            new CardForm(name, yearOfIssue).ShowDialog();
        }

        private void AddToSelectionButton_Click(object sender, System.EventArgs e)
        {
            new SelectionChangeForm(id).ShowDialog();
        }
    }
}
