using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class GenreFilm
    {
        #region DATA MEMBER
        private Genre genre;
        private Film movie;
        #endregion

        #region CONSTRUCTOR
        public GenreFilm(Genre genre, Film movie)
        {
            this.Genre = genre;
            this.Movie = movie;
        }
        public GenreFilm()
        {
            this.Genre = new Genre();
            this.Movie = new Film();
        }
        #endregion

        #region PROPERTIES
        public Genre Genre { get => genre; set => genre = value; }
        public Film Movie { get => movie; set => movie = value; }
        #endregion

        #region METHOD
        public static List<GenreFilm> BacaData(string value = "")
        {
            string query = "SELECT * FROM genre_film;";
            if (value != "")
            {
                int kode = int.Parse(value);
                query = $"SELECT * FROM genre_film where id = {kode};";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<GenreFilm> listFilm = new List<GenreFilm>();

            while (hasil.Read() == true)
            {
                GenreFilm tampung = new GenreFilm();

                List<Genre> listGenre = Genre.BacaData("id", hasil.GetValue(0).ToString());
                tampung.Genre = listGenre[0];

                List<Film> listMovie = Film.BacaData(hasil.GetValue(1).ToString());
                tampung.Movie = listMovie[0];

                listFilm.Add(tampung);
            }
            return listFilm;
        }

        public static void TambahData(GenreFilm gf)
        {
            string cmd = $"INSERT INTO genre_film(films_id, genres_id) VALUES ('{gf.Genre}', '{gf.Movie}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static void DeleteData(GenreFilm gf)
        {
            string cmd = $"DELETE FROM genre_film WHERE films_id = '{gf.Genre}'AND genres_id = '{gf.Movie}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
