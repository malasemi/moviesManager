using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movies_Manager
{
    public partial class UpdateMovie : Form
    {
        public UpdateMovie()
        {
            InitializeComponent();
        }
        // This method to clear out the text fields
        private void btnClearUpdateMovie_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtMovieTitleUpdateMovie, txtYearUpdateMovie, txtDirectorUpdateMovie, txtRottenUpdateMovie
            , txtOfficeEarningUpdateMovie};
            foreach (var item in textBoxes)
            {
                item.Clear();
            }
            combGenreUpdateMovie.ResetText();
        }
        // This method to close the "update movie dailog box"
        private void btnCloseUpdateMovie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // This method to check the required fields are not empty and to call the update method (UpdateMovie)
        private void btnUpdateMoive_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            if (MovieManagerFunctions.SearchForMovie(txtMovieTitleUpdateMovie.Text) != null)
            {
                if (txtMovieTitleUpdateMovie.Text == "")
                {
                    MessageBox.Show("Please Enter a Valid Title", "Invalid");
                    txtMovieTitleUpdateMovie.BackColor = Color.Salmon;
                    txtMovieTitleUpdateMovie.Focus();
                    return;
                }
                txtMovieTitleUpdateMovie.BackColor = Color.White;
                movie.Title = txtMovieTitleUpdateMovie.Text;

                bool isValid = int.TryParse(txtYearUpdateMovie.Text, out int year);
                if (!isValid)
                {
                    MessageBox.Show("Please Enter a Valid Year", "Invalid");
                    txtYearUpdateMovie.BackColor = Color.Salmon;
                    txtYearUpdateMovie.Focus();
                    return;
                }
                txtYearUpdateMovie.BackColor = Color.White;
                movie.Year = year;

                string mDirector = txtDirectorUpdateMovie.Text;
                if (mDirector == "")
                {
                    MessageBox.Show("Please Enter a Valid Director", "Invalid");
                    txtDirectorUpdateMovie.BackColor = Color.Salmon;
                    txtDirectorUpdateMovie.Focus();
                    return;
                }
                txtDirectorUpdateMovie.BackColor = Color.White;
                movie.Director = mDirector;

                int mGenre = combGenreUpdateMovie.SelectedIndex;
                if (mGenre < 1)
                {
                    MessageBox.Show("Please Enter a Valid Genre", "Invalid");
                    combGenreUpdateMovie.BackColor = Color.Salmon;
                    combGenreUpdateMovie.Focus();
                    return;
                }
                combGenreUpdateMovie.BackColor = Color.White;
                movie.Genre = Movie.GetGenreValue(mGenre);

                int.TryParse(txtRottenUpdateMovie.Text, out int tomatoesScore);
                movie.RottenTomatoesScore = tomatoesScore;

                decimal.TryParse(txtOfficeEarningUpdateMovie.Text, out decimal OfficeEarning);
                movie.TotalEarned = OfficeEarning;

                int result = MovieManagerFunctions.UpdateMovie(movie);
                if (result > 0)
                {
                    MessageBox.Show("Your Movie Was Updated Successfully", "Success");
                }
                else
                {
                    MessageBox.Show("Movie has not updated, please try again");
                }

            }
            else
            {
                MessageBox.Show("Movie was not found");
            }
        }
        // This method to check if the movie exist and to call the search method (SearchForMovie)
        private void btnSearchUpdateMovie_Click(object sender, EventArgs e)
        {
            string titleName = txtMovieTitleUpdateMovie.Text;
            bool isNull = string.IsNullOrEmpty(titleName);
            Movie movie = MovieManagerFunctions.SearchForMovie(titleName);

            txtMovieTitleUpdateMovie.BackColor = Color.White;
            if (isNull)
            {
                txtMovieTitleUpdateMovie.BackColor = Color.Salmon;
                txtMovieTitleUpdateMovie.Focus();
                MessageBox.Show("Please enter the movie name");
                return;
            }
            else if (movie.Title != null && !isNull)
            {
                txtDirectorUpdateMovie.Text = movie.Director;
                txtYearUpdateMovie.Text = movie.Year.ToString();
                combGenreUpdateMovie.Text = movie.Genre;
                txtRottenUpdateMovie.Text = movie.RottenTomatoesScore.ToString();
                txtOfficeEarningUpdateMovie.Text = movie.TotalEarned.ToString();
            }
            else
            {
                MessageBox.Show("Movie was not found");
            }
        }
    }
}
