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

        public static string DefineJam(int invId, string noKursi)
        {
            string jam = "";

            string query = "select jf.jam_pemutaran from jadwal_films as jf " +
                           " inner join sesi_films as sf on sf.jadwal_film_id = jf.id " +
                           " inner join tikets as t on t.jadwal_film_id = sf.jadwal_film_id" +
                           $" where t.invoices_id = {invId} and t.nomor_kursi = '{noKursi}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            while (hasil.Read() == true)
            {
                string sesi = hasil.GetValue(0).ToString();
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
            }
            
            return jam;
        }
        public static List<JadwalFilm> BacaData(string filter = "", string value = "", string jam = "")
        {
            string query = "SELECT * FROM jadwal_films;";
            if (filter != "")
            {
                query = $"SELECT * FROM jadwal_films where {filter} = '{value}';";
            }
            if (filter == "tanggal" && jam != "")
            {
                query = $"SELECT * FROM `jadwal_films` WHERE jam_pemutaran = '{jam}' AND tanggal = '{value}';";
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
