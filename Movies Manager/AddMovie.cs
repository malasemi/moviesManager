using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Movies_Manager
{
    public partial class AddMovie : Form
    {
        Movie myMovie = new Movie();        
        public AddMovie()
        {
            InitializeComponent();
        }
        // This method to close the add movie dailog box
        private void btnCloseAddMovie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // This method to clear out the text fields
        private void btnClearAddMovie_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtMovieTitleAddMovie, txtYearAddMovie, txtDirectorAddMovie, txtRottenAddMovie
            , txtOfficeEarningAddMovie};
            foreach (var item in textBoxes)
            {
                item.Clear();
            }
            combGenreAddMovie.ResetText();
        }
        // This method to check if the text fields are empty or not and to call the InsertMovie METHOD to add a movie to the database
        private void btnAddAddMoive_Click(object sender, EventArgs e)
        {
            
            if (txtMovieTitleAddMovie.Text == "")
            {
                MessageBox.Show("Please Enter a Valid Title", "Invalid");
                txtMovieTitleAddMovie.BackColor = Color.Salmon;
                txtMovieTitleAddMovie.Focus();
                return;
            }
            txtMovieTitleAddMovie.BackColor = Color.White;
            myMovie.Title = txtMovieTitleAddMovie.Text;

            bool isValid = int.TryParse(txtYearAddMovie.Text, out int year);
            if (!isValid)
            {
                MessageBox.Show("Please Enter a Valid Year", "Invalid");
                txtYearAddMovie.BackColor = Color.Salmon;
                txtYearAddMovie.Focus();
                return;
            }
            txtYearAddMovie.BackColor = Color.White;
            myMovie.Year = year;

            string mDirector = txtDirectorAddMovie.Text;
            if (mDirector == "")
            {
                MessageBox.Show("Please Enter a Valid Director", "Invalid");
                txtDirectorAddMovie.BackColor = Color.Salmon;
                txtDirectorAddMovie.Focus();
                return;
            }
            txtDirectorAddMovie.BackColor = Color.White;
            myMovie.Director = mDirector;

            int mGenre = combGenreAddMovie.SelectedIndex;
            if (mGenre < 1)
            {
                MessageBox.Show("Please Enter a Valid Genre", "Invalid");
                combGenreAddMovie.BackColor = Color.Salmon;
                combGenreAddMovie.Focus();
                return;
            }
            combGenreAddMovie.BackColor = Color.White;
            myMovie.Genre = Movie.GetGenreValue(mGenre);

            int.TryParse(txtRottenAddMovie.Text, out int rottenTomatoesScore);
            txtRottenAddMovie.BackColor = Color.White;
            myMovie.RottenTomatoesScore = rottenTomatoesScore;

            decimal.TryParse(txtOfficeEarningAddMovie.Text, out decimal boxOfficeEarning);
            myMovie.TotalEarned = boxOfficeEarning;

            if (MovieManagerFunctions.InsertMovie(myMovie) > 0)
                MessageBox.Show("Your Movie Was Added Successfully");
            else MessageBox.Show("unexpected error occurred", "ERROR");
        } 
    }
}
