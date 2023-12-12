using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class JadwalFilm
    {
        #region PROPERTIES
        public int ID { get; set; }
        public DateTime Tanggal { get; set; }
        public string Jam_Pemutaran { get; set; }
        #endregion

        #region CONSTRUCTORS 
        public JadwalFilm(int id, DateTime tanggal, string jam)
        {
            this.ID = id;
            this.Tanggal = tanggal;
            this.Jam_Pemutaran = jam;
        }
        public JadwalFilm()
        {
            this.ID = 0;
            this.Tanggal = DateTime.Now;
            this.Jam_Pemutaran = "";
        }
        #endregion

        #region METHODS
        public static List<JadwalFilm> BacaData(string value = "")
        {
            string query = "SELECT * FROM jadwal_films;";
            if (value != "")
            {
                int kode = int.Parse(value);
                query = $"SELECT * FROM jadwal_films where id = {kode};";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();

            while (hasil.Read() == true)
            {
                JadwalFilm jS = new JadwalFilm(
                    int.Parse(hasil.GetValue(0).ToString()), DateTime.Parse(
                    hasil.GetValue(1).ToString()),
                    hasil.GetValue(2).ToString());

                listJadwalFilm.Add(jS);
            }
            return listJadwalFilm;
        }

        public static void TambahData(JadwalFilm jf)
        {
            string cmd = $"INSERT INTO jadwal_films (tanggal, jam_pemutaran) " +
                $"values ('{jf.Tanggal.ToString("yyyy-MM-dd")}', '{jf.Jam_Pemutaran}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static void DeleteData(JadwalFilm jf)
        {
            string cmd = $"DELETE from jadwal_films where id = {jf.ID};";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion


    }
}
