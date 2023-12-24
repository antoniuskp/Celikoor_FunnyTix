using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class JadwalFilm
    {
        #region Data Members
        private int id;
        private DateTime tanggal;
        private string jamPemutaran;
        #endregion

        #region Contructors
        public JadwalFilm(int id, DateTime tanggal, string jamPemutaran)
        {
            this.id = id;
            this.tanggal = tanggal;
            this.jamPemutaran = jamPemutaran;
        }

        public JadwalFilm()
        {
            this.Id = 0;
            this.Tanggal = DateTime.Now;
            this.JamPemutaran = "";
        }
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }
        #endregion

        #region methods
        public static void TambahData(JadwalFilm jf)
        {
            string cmd = $"INSERT INTO jadwal_films (tanggal, jam_pemutaran) " +
                $"values ('{jf.Tanggal.ToString("yyyy-MM-dd")}', '{jf.JamPemutaran}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static void DeleteData(JadwalFilm jf)
        {
            string cmd = $"DELETE from jadwal_films where id = {jf.Id};";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static string DefineJam(string sesi)
        {
            string jam = "";
            switch (sesi)
            {
                case "I":
                    jam = "12.00 - 15.00 WIB";
                    break;
                case "II":
                    jam = "15.30 - 18.30 WIB";
                    break;
                case "III":
                    jam = "19.00 - 22.00 WIB";
                    break;
                case "IV":
                    jam = "22.30 - 01.30 WIB";
                    break;
            }
            return jam;
        }
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
                var js = new JadwalFilm();
                js.Id = int.Parse(hasil.GetValue(0).ToString());
                js.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                js.JamPemutaran = hasil.GetValue(2).ToString();

                listJadwalFilm.Add(js);
            }
            return listJadwalFilm;
        }
        #endregion

    }
}
