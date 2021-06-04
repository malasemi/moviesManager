using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Movies_Manager
{
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }
        // This method to asks the user to confirm to delete a movie and call the DeleteMovieFunction method to delete a movie
        private void btnDeleteDelMoive_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to delete this movie?",
                "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                if (DeleteMovieFunction() > 0)
                    MessageBox.Show("You removed the movie successfully");
                else MessageBox.Show("The movie has not removed, please try again");
            }
            else
            {
                MessageBox.Show("You canceled the process."
                        , "Cancel");
            }
            
        }
        // This method to close the "delete movie dailog box"
        private void btnCloseDelMovie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // This method to clear out the text fields
        private void btnClearDelMovie_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtMovieTitleDelMovie, txtYearDelMovie, txtDirectorDelMovie, txtRottenDelMovie
            , txtOfficeEarningDelMovie};
            foreach (var item in textBoxes)
            {
                item.Clear();
            }
            combGenreDelMovie.ResetText();
        }
        // This method to search in the database for a movie and return the movie details
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var titleName = txtMovieTitleDelMovie.Text;
            Movie movie = MovieManagerFunctions.SearchForMovie(titleName);

            if (movie.Title != null)
            {
                txtDirectorDelMovie.Text = movie.Director;
                txtYearDelMovie.Text = movie.Year.ToString();
                combGenreDelMovie.Text = movie.Genre;
                txtRottenDelMovie.Text = movie.RottenTomatoesScore.ToString();
                txtOfficeEarningDelMovie.Text = movie.TotalEarned.ToString();
            }
            else
            {
                MessageBox.Show("Movie was not found");
            }
        }
        // This method to delete a movie from the database if exist
        public int DeleteMovieFunction()
        {
            Movie movie = new Movie();
            int result = 0;
            string commandN = "DELETE FROM dbo.Movies WHERE Title = @Title";
            try
            {
                string connectionString = MovieManagerFunctions.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(commandN, connection))
                    {
                        command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = txtMovieTitleDelMovie.Text;
                        connection.Open();

                        result = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
