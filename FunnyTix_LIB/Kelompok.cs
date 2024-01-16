using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class Kelompok
    {
        #region DATA MEMBERS
        private int id;
        private string nama;
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region CONSTRUCTOR
        public Kelompok(string nama)
        {
            this.Id = 0;
            this.Nama = nama;
        }
        public Kelompok()
        {
            this.Id = 0;
            this.Nama = "";
        }
        #endregion

        #region METHODS
        public static List<Kelompok> BacaData(string filter = "", string val = "")
        {
            string cmd = (filter == "") ? $"SELECT * FROM kelompoks" : $"SELECT * FROM kelompoks WHERE {filter} LIKE '%{val}%';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            List<Kelompok> lstKelompok = new List<Kelompok>();
            while (res.Read() == true)
            {
                Kelompok k = new Kelompok();
                k.Id = int.Parse(res.GetValue(0).ToString());
                k.Nama = res.GetValue(1).ToString();

                lstKelompok.Add(k);
            }
            return lstKelompok;
        }
        public static void TambahData(Kelompok k)
        {
            string cmd = $"INSERT INTO kelompoks(nama) VALUES ('{k.Nama}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        public static void DeleteData(string kodeHapus)
        {
            string cmd = $"Select id from films where kelompoks_id = '{kodeHapus}';";

            var hasil = Koneksi.JalankanPerintahSelect(cmd);
            
            while (hasil.Read())
            {
                int id = hasil.GetInt32(0);
                cmd = $"Delete from tikets where films_id = '{id}'";
                Koneksi.JalankanPerintahNonQuery(cmd);

                cmd = $"Delete from sesi_films where films_id = '{id}'";
                Koneksi.JalankanPerintahNonQuery(cmd);

                cmd = $"Delete from film_studio where films_id = '{id}'";
                Koneksi.JalankanPerintahNonQuery(cmd);

                cmd = $"DELETE from genre_film where films_id = '{id}'";
                Koneksi.JalankanPerintahNonQuery(cmd);
            }

            cmd = $"Delete from films where kelompoks_id = '{kodeHapus}';";
            Koneksi.JalankanPerintahNonQuery(cmd);

            cmd = $"DELETE FROM kelompoks WHERE id = '{kodeHapus}';";
            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
