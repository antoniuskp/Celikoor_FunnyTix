using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class Genre
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Deskripsi { get; set; }
        #endregion

        #region CONSTRUSTOR
        public Genre(string nama, string deskripsi)
        {
            ID = 0;
            Nama = nama;
            Deskripsi = deskripsi;
        }
        public Genre()
        {
            ID = 0;
            Nama = "";
            Deskripsi = "";
        }
        #endregion

        #region METHODS
        public static List<Genre> BacaData(string filter = "", string val = "")
        {
            string cmd = (filter == "") ? $"SELECT * FROM genres" : $"SELECT * FROM genres WHERE {filter} LIKE '%{val}%';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            var lstGenres = new List<Genre>();

            while(res.Read() == true)
            {
                Genre g = new Genre(res.GetValue(1).ToString(), res.GetValue(2).ToString());
                g.ID = int.Parse(res.GetValue(0).ToString());

                lstGenres.Add(g);
            }
            return lstGenres;
        }
        public static void TambahData(Genre g)
        {
            string cmd = $"INSERT INTO genres(nama, deskripsi) VALUES ('{g.Nama}', '{g.Deskripsi}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        public static void DeleteData(string kodeHapus)
        {
            string cmd = $"DELETE FROM genres WHERE id = '{kodeHapus}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
