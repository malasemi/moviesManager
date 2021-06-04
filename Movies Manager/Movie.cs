
namespace Movies_Manager
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int RottenTomatoesScore { get; set; }
        public decimal TotalEarned { get; set; }

        public static string[] genreList = {"", "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery",
            "Romance", "Science Fiction", "Western"};
       // A method to return the genre based on the index or "" if the index in 0
        public static string GetGenreValue(int value)
        {
            string result;
            if (value > 9 || value < 0)
            {
                result = "";
            }
            else
            {
                result = genreList[value];
            }
            return result;
        }
        // This method to know the index based on a given genre
        public static int GetValueOfGenre(string str)
        {
            int i;
            for (i = 0 ; i < genreList.Length; i++)
            {
                if (genreList[i].Equals(str)) break;
            }
            return i;
        }
    }
}
