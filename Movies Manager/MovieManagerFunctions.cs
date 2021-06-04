using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Movies_Manager
{
    public class MovieManagerFunctions
    {
        // This method to search in the database for a movie and return the movie details
        public static Movie SearchForMovie(string value)
        {
            Movie movie = new Movie();
            string commandN = "SELECT Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM dbo.Movies WHERE Title = @MovieName";
            try
            {
                string connectionString = GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(commandN, connection))
                    {
                        command.Parameters.Add("MovieName", SqlDbType.VarChar, 50).Value = value;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                movie.Title = reader.GetString(0);

                                movie.Year = reader.GetInt32(1);

                                movie.Director = reader.GetString(2);

                                int genreDescription = reader.GetInt32(3);
                                movie.Genre = Movie.GetGenreValue(genreDescription);

                                if (!reader.IsDBNull(4))
                                    movie.RottenTomatoesScore = reader.GetInt32(4);
                                

                                if (!reader.IsDBNull(5))
                                    movie.TotalEarned = reader.GetDecimal(5);
                                
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return movie;
        }
        // This method to return the entire movies in the database
        public static List<Movie> ReadFromDatabase()
        {
            string connectionString = GetConnectionString();
            string commandN = "SELECT Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM dbo.Movies " +
                "ORDER BY Title";
            List<Movie> movies = new List<Movie>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(commandN, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var p = new Movie();

                                p.Title = reader.GetString(1);

                                p.Year = reader.GetInt32(2);

                                p.Director = reader.GetString(3);

                                int genreDescription = reader.GetInt32(4);
                                p.Genre = Movie.GetGenreValue(genreDescription);

                                if (!reader.IsDBNull(5))
                                    p.RottenTomatoesScore = reader.GetInt32(5);
                                

                                if (!reader.IsDBNull(6))
                                    p.TotalEarned = reader.GetDecimal(6);
                                

                                movies.Add(p);
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return movies;
        }
        // This method return the database connection string
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433";
            builder.InitialCatalog = "CSCI1630";
            builder.UserID = "rw1630";
            builder.Password = "Project!";

            return builder.ConnectionString;
        }
        // This method to update the movie in the database
        public static int UpdateMovie(Movie movie)
        {
            int result = 0;
            try
            {
                string connectionString = GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(
                        "UPDATE dbo.Movies SET Title = @Title, Year = @Year, Director = @Director, Genre = @Genre, " +
                        "RottenTomatoesScore = @RottenTomatoesScore, TotalEarned = @TotalEarned "+
                        "WHERE Title = @Title", connection))
                    {
                        command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = movie.Title;
                        command.Parameters.Add("Year", SqlDbType.Int).Value = movie.Year;
                        command.Parameters.Add("Director", SqlDbType.VarChar, 50).Value = movie.Director;
                        command.Parameters.Add("Genre", SqlDbType.Int).Value = Movie.GetValueOfGenre(movie.Genre);
                        command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = movie.RottenTomatoesScore;
                        command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = movie.TotalEarned;
                        connection.Open();
                        result = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        // This method to add a movie into the database
        public static int InsertMovie(Movie movie)
        {
            int result = 0;
            try
            {
                string connectionString = MovieManagerFunctions.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO dbo.Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned) " +
                        "VALUES (@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)", connection))
                    {
                        command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = movie.Title;
                        command.Parameters.Add("Year", SqlDbType.Int).Value = movie.Year;
                        command.Parameters.Add("Director", SqlDbType.VarChar, 50).Value = movie.Director;
                        command.Parameters.Add("Genre", SqlDbType.Int).Value = Movie.GetValueOfGenre(movie.Genre);
                        command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = movie.RottenTomatoesScore;
                        command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = movie.TotalEarned;
                        connection.Open();
                        result = command.ExecuteNonQuery();
                    }
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
