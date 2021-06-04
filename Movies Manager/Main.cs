/*
 * Majed Alasemi
 * Movie Manager Application
 * 12/13/2020
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Movies_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // This method to close the application
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // This method to show the 'About Us' page
        private void mnuAboutD_Click(object sender, EventArgs e)
        {
            MnuAbout mnuAbout = new MnuAbout();
            mnuAbout.ShowDialog();
        }
        // This method call the LoadMovies method to load the movies in the database
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }
        // This method to refresh the database
        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        // This method to open the add movie dialog
        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }
        // This method to open the update movie dialog
        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMovie updateMovie = new UpdateMovie();
            updateMovie.ShowDialog();
        }
        // This method to open the delete movie dialog
        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMovie deleteMovie = new DeleteMovie();
            deleteMovie.ShowDialog();
        }
        // This method loads movies from the database and shows them in a gridData
        private void LoadMovies()
        {
            List<Movie> movies = MovieManagerFunctions.ReadFromDatabase();
            gridData.DataSource = movies;
            gridData.Columns[5].DefaultCellStyle.Format = "C";
            gridData.Columns[0].HeaderText = "Movie Title";
            gridData.Columns[4].HeaderText = "Rotten Tomatoes Score";
            gridData.Columns[5].HeaderText = "Total Box Office";
        }
    }
}
